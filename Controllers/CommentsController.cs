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

    [ODataRoutePrefix("Comments")]
    public class CommentsController : ODataController
    {
        private readonly XxxDbContext xxxDbContext;
        public CommentsController(XxxDbContext xxxDbContext)
                => this.xxxDbContext = xxxDbContext;

        [ODataRoute]
        [EnableQuery]
        //[PagingValidatorQuery]
        public IActionResult Index()
        {
            return Ok(this.xxxDbContext.Comments);
        }


    }
}
