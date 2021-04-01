using System;
using Models;
using Repository;

namespace BusinessLogic
{
    public class UserMethods
    {
        private readonly loversRepo _repolayer;
        private readonly Mapper mapper = new Mapper();

        public UserMethods() { }// create a parameterless constructor so that I can create this class in the testing suite.
        public UserMethods(loversRepo repolayer)
        {
            this._repolayer = repolayer;
        }

        /// <summary>
        /// This method takes a user and returns a verified user, if it exists.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Customer Login(Customer user)
        {
            //call a method on the repository class that will query the Db
            // and return the verified person, if he exists.
            // otherwise return a Person with empty strings.
            user.Fname += user.Lname;
            user.Lname += user.Fname;

            Customer user1 = _repolayer.Login(user);

            return user1;
        }

        public Customer Register(RawCust rawCust)
        {
            if (_repolayer.UserExists(rawCust.Username) == true)
            {
                return null;
            }
            else
            {
                //convert this rawperson to a Person
                // send in the submitted password and get back a Person obj with the hashed password and key for it.
                Customer newCustomer = mapper.GetANewCustomerWithHashedPassword(rawCust.Password);

                //transfer in the supplied data
                newCustomer.Fname = rawCust.Fname;
                newCustomer.Lname = rawCust.Lname;
                newCustomer.UserName = rawCust.Username;
                Customer registeredCustomer = _repolayer.Register(newCustomer);//call a method on the repo layer to save the new person to the DB.
                return registeredCustomer;
            }
        }

        public Customer Login(string username, string password)
        {
            if (_repolayer.UserExists(username) == false)
            {
                return null;
            }
            else
            {
                //get the matching user with this Username
                Customer foundCustomer = _repolayer.GetCustomerByUsername(username);

                // hash the provided password with the key from the found user
                byte[] hash = mapper.HashThePassword(password, foundCustomer.PasswordSalt);

                // compare the 2 hashes with a external method
                // if the 2 hashes match return the found user.
                if (CompareTwoHashes(foundCustomer.PasswordHash, hash))
                {
                    return foundCustomer;
                }
                else return null;
            }
        }

        private bool CompareTwoHashes(byte[] arr1, byte[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            //compare the hash of the inputted password and the found user
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                } // Unauthorized("Invalid Password");
            }
            return true;
        }



    }// end of class
}// end of namespace