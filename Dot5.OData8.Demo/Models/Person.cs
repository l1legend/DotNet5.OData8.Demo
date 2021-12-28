using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dot5.OData8.Demo.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BankAccounts> BankAccounts { get; set; }
    }

    public class BankAccounts
    {
        public int AccountId { get; set; }
        public string BankName { get; set; }
    }
}
