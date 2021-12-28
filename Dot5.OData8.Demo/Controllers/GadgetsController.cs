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
    [Route("api/[controller]")]
    [ApiController]
    public class GadgetsController : ControllerBase
    {
        private readonly MyWorldDbContext _myWorldDbContext;

        public GadgetsController(MyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        [HttpGet]
        [Route("all")]
        [EnableQuery]
        public IActionResult GetAll()
        {
            return Ok(_myWorldDbContext.Gadgets.AsQueryable());
        }
    }
}
