using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Repository
{
    public class LoversRepo
    {
        private readonly loversContext _context;
        public LoversRepo() { }
        public LoversRepo(loversContext context)
        {
            this._context = context;
        }

        public Customer Login(Customer user)
        {
            /**use the context to call the Db 
            and query for the first usr that matches 
            the first and last name*/
            Customer user1 = _context.Customers.FirstOrDefault(p => p.Fname == user.Fname && p.Lname == user.Lname);
            return user1;

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

        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            books = _context.Books.ToList();
            return books;
        }

        public bool BookExists(Book book)
        {
            //default is NULL
            if (_context.Books.Where(b => b.Title == book.Title).FirstOrDefault() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Order NewOrder(Guid custId, string storeName)
        {
            Order order = new Order();
            order.Store = storeName;
            order.CustomerId = custId;
            var newOrder1 = _context.Orders.Add(order);
            _context.SaveChanges();
            return _context.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);
        }

        public Order UpdateOrder(Guid orderId, Guid bookId)
        {
            Order order1 = _context.Orders.Where(o => o.OrderId == orderId).FirstOrDefault();
            Book book1 = _context.Books.Where(b => b.BookId == bookId).FirstOrDefault();
            order1.Books.Add(book1);
            order1.Price = Decimal.Add(order1.Price, book1.Price);
            var ord = _context.Orders.Update(order1);
            _context.SaveChanges();
            return order1;
        }
    }
}
