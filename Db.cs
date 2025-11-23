using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace AccountingSystemWinForms
{
    public static class Db
    {
        private static bool _initialized;

        public static string DbPath
        {
            get
            {
                var dir = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "AccountingSystemWinForms");

                Directory.CreateDirectory(dir);
                return Path.Combine(dir, "AccountingSystem.db");
            }
        }

        public static string ConnectionString =>
            new SqliteConnectionStringBuilder { DataSource = DbPath }.ToString();

        public static void Initialize()
        {
            if (_initialized) return;

            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            using var cmd = con.CreateCommand();
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    FullName     TEXT NOT NULL,
    Username     TEXT UNIQUE,
    Email        TEXT NOT NULL UNIQUE,
    PasswordHash TEXT NOT NULL,
    CreatedAt    TEXT NOT NULL
);";
            cmd.ExecuteNonQuery();

            // Make sure Username index exists
            using var ix = con.CreateCommand();
            ix.CommandText = @"
CREATE UNIQUE INDEX IF NOT EXISTS IX_Users_Username
ON Users(Username);";
            ix.ExecuteNonQuery();

            _initialized = true;
        }
    }
}
