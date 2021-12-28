using Dot5.OData8.Demo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dot5.OData8.Demo.Controllers
{
    public class OdataGadgetsController : ControllerBase
    {
        private readonly MyWorldDbContext _myWorldDbContext;

        public OdataGadgetsController(MyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        [HttpGet]
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_myWorldDbContext.Gadgets.AsQueryable());
        }
    }
}
