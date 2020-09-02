using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApplication.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebApplication.Controllers
{
    public class MasterController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/agent/getData")]
        public IActionResult getData()
        {

            CoreDBContext context = new CoreDBContext();

           var MedicinesData = context.Medicines.List();
            return Ok(MedicinesData);
        }
    }
}
