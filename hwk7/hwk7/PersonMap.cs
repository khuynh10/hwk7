using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwk7
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            Property(p => p.FirstName)
          .HasMaxLength(30);
            Property(p => p.LastName)
                .HasMaxLength(30);
        }
    }
}
