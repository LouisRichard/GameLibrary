using System;
using System.Security.Cryptography;

namespace DataManager
{
    /// <summary>
    /// This class can hash the password and verifies the hash.
    /// </summary>
    //Source code https://stackoverflow.com/questions/4181198/how-to-hash-a-password/10402129#10402129
    public class CryptoPassword
    {
        #region attributes

        /// <summary>
        /// Size of salt.
        /// </summary>
        private const int saltSize = 16;

        /// <summary>
        /// Size of hash.
        /// </summary>
        private const int hashSize = 20;

        /// <summary>
        /// Numbre of iterations.
        /// </summary>
        private const int iterations = 10000;

        #endregion attributes

        #region public methods

        /// <summary>
        /// This method takes a password, hash it with salt and resalt it.
        /// </summary>
        /// <param name="password">Password to hash</param>
        /// <returns>Password hashed and salted</returns>
        public string Hash(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[saltSize]);

            // Create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(hashSize);

            // Combine salt and hash
            var hashBytes = new byte[saltSize + hashSize];
            Array.Copy(salt, 0, hashBytes, 0, saltSize);
            Array.Copy(hash, 0, hashBytes, saltSize, hashSize);

            // Convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            // Format hash with extra information
            return string.Format("$GAMECRYPT$V1${0}${1}", iterations, base64Hash);
        }


        /// <summary>
        /// Verifies a password against a hash.
        /// </summary>
        /// <param name="password">The password</param>
        /// <param name="hashedPassword">The hash</param>
        /// <returns>Could be verified?</returns>
        public bool Verify(string password, string hashedPassword)
        {
            // Extract iteration and Base64 string
            var splittedHashString = hashedPassword.Replace("$GAMECRYPT$V1$", "").Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];

            // Get hash bytes
            var hashBytes = Convert.FromBase64String(base64Hash);

            // Get salt
            var salt = new byte[saltSize];
            Array.Copy(hashBytes, 0, salt, 0, saltSize);

            // Create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(hashSize);

            // Get result
            for (var i = 0; i < hashSize; i++)
            {
                if (hashBytes[i + saltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

        #endregion public methods
    }
}
