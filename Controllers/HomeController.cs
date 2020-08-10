using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ODataDemo.Data;
using ODataDemo.Models;

namespace ODataDemo.Controllers
{
    [ODataRoutePrefix("Student")]
    public class HomeController : ODataController
    {
        private readonly XxxDbContext xxxDbContext;
        public HomeController(XxxDbContext xxxDbContext)
                => this.xxxDbContext = xxxDbContext;

        [HttpGet]
        [EnableQuery]
        public IActionResult Index()
        {

            var list = new List<Student>
            {
                new Student()
            };
            return Ok(list);

        }

        

    }
}
