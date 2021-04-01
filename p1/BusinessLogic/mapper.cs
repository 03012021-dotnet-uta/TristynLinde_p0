using System.Security.Cryptography;
using System.Text;
using Models;

namespace BusinessLogic
{
    public class Mapper
    {
        /// <summary>
        /// this override method takes a user inputted password and returns a unique hash for it
        /// /// </summary>
        /// <returns></returns>
        public Customer GetANewCustomerWithHashedPassword(string passwordString)
        {
            using (var hmac = new HMACSHA512())
            {
                Customer user = new Customer()
                {
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(passwordString)),//this returns a byte[] representing the password
                    PasswordSalt = hmac.Key     // this assigns the randomly generated Key (comes with the HMAC instance) to the salt variable of the user instance,
                };
                return user;
            }
        }

        public byte[] HashThePassword(string password, byte[] key)
        {
            using HMACSHA512 hmac = new HMACSHA512(key: key);

            var hashedPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return hashedPassword;
        }




    }// end of class
}// end of namespace