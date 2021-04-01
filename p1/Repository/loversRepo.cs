using System;
using System.Linq;
using Models;

namespace Repository
{
    public class loversRepo
    {
        private readonly loversContext _context;
        public loversRepo() { }// create this so that you can test this class without having to also create a context and repo.
        public loversRepo(loversContext context)
        {
            this._context = context;
        }

        public Customer Login(Customer user)
        {
            /**use the context to call the Db 
            and query for the first usr that matches 
            the first and last name*/
            //Person user = context.Person.FirstOrDefault(p => p.Fname == user.Fname && p.Lname == user.Lname);
            Customer user1 = new Customer()
            {
                Fname = "Jerry",
                Lname = "Walker"
            };

            user.Fname += user1.Fname;
            user.Lname += user1.Lname;

            return user;

        }

        /// <summary>
        /// Takes a username and returns true if the username is found in the Db.
        /// Otherwise returns false.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool UserExists(string userName)
        {
            //default is NULL
            if (_context.Customers.Where(p => p.UserName == userName).FirstOrDefault() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method adds the verified new user to the Db and returns the Person object from the Db
        /// </summary>
        /// <param name="newCustomer"></param>
        /// <returns></returns>
        public Customer Register(Customer newCustomer)
        {
            var newCustomer1 = _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return _context.Customers.FirstOrDefault(p => p.CustomerId == newCustomer.CustomerId);
        }

        /// <summary>
        /// This method takes a string of the username and returns the Person object from the Db
        /// If no person is found, returns null.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Customer GetCustomerByUsername(string username)
        {
            Customer foundCustomer = _context.Customers.FirstOrDefault(p => p.UserName == username);
            return foundCustomer;
        }


    }
}
