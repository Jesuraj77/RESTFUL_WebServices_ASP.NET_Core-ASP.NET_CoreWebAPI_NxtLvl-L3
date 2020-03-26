using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level3.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            //.Enable Paging, Sorting and Filtering to the data being rendered byGet Customers API (Created in previous steps)
            return View();
        }
    }
}