using Dot5.OData8.Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dot5.OData8.Demo.Data
{
    public class MyWorldDbContext : DbContext
    {

        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
        {

        }
        public DbSet<Gadgets> Gadgets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilders)
        {
            //below line to watch the ef core sql queries generation
            //not at all recommended for the production code
            //optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}
