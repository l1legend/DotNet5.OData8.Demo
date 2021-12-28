using Dot5.OData8.Demo.Data;
using Dot5.OData8.Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Collections.Generic;


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

        [HttpGet]
        [Route("person")]
        [EnableQuery]
        public IActionResult GetPerson()
        {
            var person = new Person
            {
                Id = 1,
                Name = "Michael",
                BankAccounts = new List<BankAccounts>
                {
                    new BankAccounts
                    {
                        AccountId = 111,
                        BankName = "Bank1"
                    },

                    new BankAccounts
                    {
                        AccountId = 222,
                        BankName = "Bank2"
                    }
                }

            };
            var result = new List<Person>();
            result.Add(person);
            return Ok(result);
        }
    }
}
