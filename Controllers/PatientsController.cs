using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using ODataDemo.Data;
using ODataDemo.Models;

namespace ODataDemo.Controllers
{
    [ODataRoutePrefix("Patients")]
    public class PatientsController : ODataController
    {
        private readonly XxxDbContext xxxDbContext;
        public PatientsController(XxxDbContext xxxDbContext)
                => this.xxxDbContext = xxxDbContext;


        [ODataRoute]
        [EnableQuery]
        public IActionResult index()
        {

            var list = new List<Patient>
            {
                new Patient()
            };
            var error = list.FirstOrDefault().ErrorProperty;
            return Ok();
 
        }

        [ODataRoute("{id}")]
        [EnableQuery]
        public IActionResult Get([FromODataUri] ulong id)
        {
            return Ok(this.xxxDbContext.Patients.FirstOrDefault(item => item.PatientId == id));
        }


    }
}
