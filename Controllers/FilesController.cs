using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using ODataDemo.Data;

namespace ODataDemo.Controllers
{
    [ODataRoutePrefix("Files")]
    public class FilesController : ODataController
    {
        private readonly XxxDbContext xxxDbContext;
        public FilesController(XxxDbContext xxxDbContext)
                => this.xxxDbContext = xxxDbContext;


        [ODataRoute]
        [EnableQuery]
        public IActionResult Index()
        {
            return Ok(this.xxxDbContext.Files);
        }


    }
}
