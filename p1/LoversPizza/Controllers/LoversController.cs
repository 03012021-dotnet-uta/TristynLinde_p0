using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoversPizza
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoversController : ControllerBase
    {
        private readonly UserMethods _business;
        public LoversController(UserMethods business)
        {
            this._business = business;
        }

        [HttpPost("register")]
        public ActionResult<Customer> Register(RawCust rawCust)
        {
            System.Console.WriteLine(rawCust.Fname);
            Customer customer = new Customer();
            if (!ModelState.IsValid)// did the conversion from JS to C# work?
            {
                // return StatusCode(409, $"User '{rawPerson.UserName}' already exists.");
                return StatusCode(400, "That was a failue of modelbinding");
            }
            else
            {
                // here you will use the bussiness logic layer instance to pass the data to that layer and eventually save it to the Db.
                //Console.WriteLine($"{rawperson.Fname}, {rawperson.Lname}");
                customer = _business.Register(rawCust);
            }

            //check if person is null!!!
            if (customer == null)
            {
                return StatusCode(409, "We're sorry, your new user was not successfully saved or a user of that username already exists.");
            }
            return customer;
        }

        // THIS IS AN ACTION METHOD
        // GET: api/<LoversController>
        [HttpGet("login/{username}/{password}")]
        public ActionResult<Customer> Login(string username, string password)
        {
            // return new string[] { "Mark", "Moore" };
            //here we will do mich the same as in the register.....
            Customer customer = new Customer();
            if (!ModelState.IsValid)// did the conversion from JS to C# work?
            {
                // return StatusCode(409, $"User '{rawPerson.UserName}' already exists.");
                return StatusCode(400, "That was a failure of modelbinding");
            }
            else
            {
                // here you will use the bussiness logic layer instance to pass the data to that layer and eventually save it to the Db.
                //Console.WriteLine($"{rawperson.Fname}, {rawperson.Lname}");
                customer = _business.Login(username, password);
            }

            //check if person is null!!!
            if (customer == null)
            {
                return StatusCode(409, "We're sorry, your username was not found.");
            }
            return customer;
        }

        [HttpGet("menu")]
        public List<Book> PopulateMenu()
        {
            List<Book> books = new List<Book>();
            books = _business.ShowBooks();
            return books;
        }
    }
}
