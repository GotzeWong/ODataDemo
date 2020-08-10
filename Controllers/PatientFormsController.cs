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
    [ODataRoutePrefix("PatientForms")]
    public class PatientFormsController : ODataController
    {
        private readonly XxxDbContext xxxDbContext;
        public PatientFormsController(XxxDbContext xxxDbContext)
                => this.xxxDbContext = xxxDbContext;


        [ODataRoute]
        [EnableQuery]
        //[PagingValidatorQuery]
        public IActionResult index()
        {
            return Ok(this.xxxDbContext.PatientForms);
        }


    }
}
