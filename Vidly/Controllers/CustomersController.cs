﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            Customer cust = new Customer();

          
           
            
            //Customer.Customers.Add(cust2);
           return View(cust);
        }

        
    }
}