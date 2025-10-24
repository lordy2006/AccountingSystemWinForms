using System.Security.Cryptography;

namespace AccountingSystemWinForms
{
    public static class Passwords
    {
        private const int Iterations = 120_000;
        private const int SaltSize = 16;   // 128-bit
        private const int KeySize = 32;   // 256-bit

        public static string Hash(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, KeySize);
            return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        public static bool Verify(string password, string record)
        {
            var parts = record.Split('.');
            if (parts.Length != 3) return false;

            var iterations = int.Parse(parts[0]);
            var salt = Convert.FromBase64String(parts[1]);
            var stored = Convert.FromBase64String(parts[2]);

            var test = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, HashAlgorithmName.SHA256, stored.Length);
            return CryptographicOperations.FixedTimeEquals(stored, test);
        }
    }
}