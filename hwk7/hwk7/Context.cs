using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwk7
{
    public class Context : DbContext
    {
        public Context()
            : base("name=chapter2")
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Company> Companies { get; set; }

    }
}
