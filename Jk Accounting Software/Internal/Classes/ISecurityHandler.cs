using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using JkComponents;
using System.Data;

namespace Jk_Accounting_Software.Internal.Classes
{
    public static class ISecurityHandler
    {
        public static int CompanyId { get; set; }
        public static int SecurityUserId { get; set; }
        public static String CompanyName { get; set; }
        public static String SecurityUserName { get; set; }
        public static String ProductName { get; set; }
        public static String ProductVersion { get; set; }

        public static bool PasswordStrong(String Password)
        {
            List<char> alphabet = new List<char>();
            List<char> numbers = new List<char>();
            List<char> specialCharacters = new List<char>();

            bool containsAlphabet = false;
            bool containsNumber = false;
            bool containsSpecialChar = false;

            for (int i = 65; i <= 90; i++)
            {
                alphabet.Add((char)i);
                alphabet.Add(((char)i).ToString().ToLower()[0]);
            }

            for (int i = 0; i <= 9; i++)
                numbers.Add(char.Parse(i.ToString()));

            for (int i = 32; i <= 126; i++)
            {
                if (!alphabet.Contains((char)i)
                    && !numbers.Contains((char)i))
                    specialCharacters.Add((char)i);
            }


            foreach (char letters in Password)
            {
                if (alphabet.Contains(letters))
                    containsAlphabet = true;

                if (numbers.Contains(letters))
                    containsNumber = true;

                if (specialCharacters.Contains(letters))
                    containsSpecialChar = true;
            }

            return containsAlphabet
                && containsNumber
                && containsSpecialChar;
        }

        public static String Encrypt(String Password)
        {
            const int SALT_BYTE_SIZE = 24;
            const int HASH_BYTE_SIZE = 24;
            const int PBKDF2_ITERATIONS = 1000;

            // Generate a random salt
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_BYTE_SIZE];
            csprng.GetBytes(salt);

            // Hash the password and encode the parameters
            byte[] hash = PBKDF2(Password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
            return PBKDF2_ITERATIONS + ":" +
                Convert.ToBase64String(salt) + ":" +
                Convert.ToBase64String(hash);
        }

        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }

        private static bool ValidatePassword(string password, string correctHash)
        {
            const int ITERATION_INDEX = 0;
            const int SALT_INDEX = 1;
            const int PBKDF2_INDEX = 2;

            // Extract the parameters from the hash
            char[] delimiter = { ':' };
            string[] split = correctHash.Split(delimiter);
            int iterations = Int32.Parse(split[ITERATION_INDEX]);
            byte[] salt = Convert.FromBase64String(split[SALT_INDEX]);
            byte[] hash = Convert.FromBase64String(split[PBKDF2_INDEX]);

            byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }

        public static bool LoginCredentialAccepted(String Username, String Password)
        {
            ITransactionHandler VTransactionHandler = new ITransactionHandler();
            String CommandText =
                "SELECT Id, [Password], FormalName FROM tblSystemUsers " +
                "WHERE Username = @Username " +
                "COLLATE Latin1_General_CS_AS";
            JkFormParameter param = new JkFormParameter();
            List<JkFormParameter> paramList = new List<JkFormParameter>();
            DataTable table = new DataTable();

            param.Name = "Username";
            param.Value = Username;
            paramList.Add(param);

            table = VTransactionHandler.LoadData(CommandText, paramList);

            if (table.Rows.Count > 0)
            {
                //TODO: Company information should also be based on login
                ISecurityHandler.CompanyId = 1;
                ISecurityHandler.CompanyName = "Jk Computer Systems Inc.";

                ISecurityHandler.SecurityUserId = int.Parse(table.Rows[0][0].ToString());
                ISecurityHandler.SecurityUserName = table.Rows[0][2].ToString();

                return ValidatePassword(Password, table.Rows[0][1].ToString());
            }

            return false;
        }
    }
}
