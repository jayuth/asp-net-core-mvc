using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // to access to the database, apply the following code - a private field
        private ApplicationDbContext _context;

        // then initialize the dbcontext
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // dispose db object
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            // get customers from the databse
            // by using ToList, SQL code will execute immediately. So, we don't have to execute SQL code in a view 
            var customers = _context.Customers.ToList();
            /* hard code
            var customers = GetCustomers();
            */
            return View(customers);
        }

        // Details of each customer
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            // var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null) return NotFound();
            return View(customer);
        }

        // hard code - before implementing database
        // create a list of customers
        /*
        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer{ Id = 1, Name = "Customer A" },
                new Customer{ Id = 2, Name = "Customer B" }
            };

            return customers;
        }
        */
    }
}
