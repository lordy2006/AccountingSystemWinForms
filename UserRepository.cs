using System;
using Microsoft.Data.Sqlite;

namespace AccountingSystemWinForms
{
    public sealed class User
    {
        public long Id { get; init; }
        public string FullName { get; init; } = "";
        public string? Username { get; init; }
        public string Email { get; init; } = "";
        public DateTime CreatedAt { get; init; }
    }

    public class UserRepository
    {
        // Ensure Users.Username exists (for older DBs created before we added it)
        private static void EnsureUsernameColumn(SqliteConnection con)
        {
            using var check = con.CreateCommand();
            check.CommandText = "SELECT 1 FROM pragma_table_info('Users') WHERE name='Username' LIMIT 1;";
            var exists = check.ExecuteScalar() != null;
            if (!exists)
            {
                using (var alter = con.CreateCommand())
                {
                    alter.CommandText = "ALTER TABLE Users ADD COLUMN Username TEXT";
                    alter.ExecuteNonQuery();
                }
                using (var ix = con.CreateCommand())
                {
                    ix.CommandText = "CREATE UNIQUE INDEX IF NOT EXISTS IX_Users_Username ON Users(Username)";
                    ix.ExecuteNonQuery();
                }
            }
        }

        public void CreateUser(string fullName, string username, string email, string password)
        {
            Db.Initialize();
            var passwordHash = Passwords.Hash(password);

            using var con = new SqliteConnection(Db.ConnectionString);
            con.Open();
            EnsureUsernameColumn(con);

            using var cmd = con.CreateCommand();
            cmd.CommandText = @"
INSERT INTO Users (FullName, Username, Email, PasswordHash, CreatedAt)
VALUES ($n, $u, $e, $p, $c);";
            cmd.Parameters.AddWithValue("$n", fullName.Trim());
            cmd.Parameters.AddWithValue("$u", string.IsNullOrWhiteSpace(username) ? DBNull.Value : username.Trim());
            cmd.Parameters.AddWithValue("$e", email.Trim());
            cmd.Parameters.AddWithValue("$p", passwordHash);
            cmd.Parameters.AddWithValue("$c", DateTime.UtcNow.ToString("o"));
            cmd.ExecuteNonQuery();
        }

        public bool EmailExists(string email)
        {
            Db.Initialize();
            using var con = new SqliteConnection(Db.ConnectionString);
            con.Open();

            using var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT 1 FROM Users WHERE Email = $e LIMIT 1;";
            cmd.Parameters.AddWithValue("$e", email.Trim());
            using var r = cmd.ExecuteReader();
            return r.Read();
        }

        public bool UsernameExists(string username)
        {
            Db.Initialize();
            using var con = new SqliteConnection(Db.ConnectionString);
            con.Open();
            EnsureUsernameColumn(con);

            using var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT 1 FROM Users WHERE Username = $u LIMIT 1;";
            cmd.Parameters.AddWithValue("$u", username.Trim());
            using var r = cmd.ExecuteReader();
            return r.Read();
        }

        // identifier can be a username OR an email
        public bool ValidateCredentials(string identifier, string password)
        {
            Db.Initialize();
            using var con = new SqliteConnection(Db.ConnectionString);
            con.Open();
            EnsureUsernameColumn(con);

            using var cmd = con.CreateCommand();
            cmd.CommandText = @"
SELECT PasswordHash
FROM Users
WHERE (Username = $id OR Email = $id)
LIMIT 1;";
            cmd.Parameters.AddWithValue("$id", identifier.Trim());
            var record = cmd.ExecuteScalar() as string;
            return record is not null && Passwords.Verify(password, record);
        }

        public string? GetFullNameByIdentifier(string identifier)
        {
            Db.Initialize();
            using var con = new SqliteConnection(Db.ConnectionString);
            con.Open();
            EnsureUsernameColumn(con);

            using var cmd = con.CreateCommand();
            cmd.CommandText = @"
SELECT FullName
FROM Users
WHERE (Username = $id OR Email = $id)
LIMIT 1;";
            cmd.Parameters.AddWithValue("$id", identifier.Trim());
            return cmd.ExecuteScalar() as string;
        }

        // Optional: fetch full user (handy for your Main form label)
        public User? GetUserByIdentifier(string identifier)
        {
            Db.Initialize();
            using var con = new SqliteConnection(Db.ConnectionString);
            con.Open();
            EnsureUsernameColumn(con);

            using var cmd = con.CreateCommand();
            cmd.CommandText = @"
SELECT Id, FullName, Username, Email, CreatedAt
FROM Users
WHERE (Username = $id OR Email = $id)
LIMIT 1;";
            cmd.Parameters.AddWithValue("$id", identifier.Trim());

            using var r = cmd.ExecuteReader();
            if (!r.Read()) return null;

            return new User
            {
                Id = r.GetInt64(0),
                FullName = r.GetString(1),
                Username = r.IsDBNull(2) ? null : r.GetString(2),
                Email = r.GetString(3),
                CreatedAt = DateTime.Parse(r.GetString(4))
            };
        }
    }
}
