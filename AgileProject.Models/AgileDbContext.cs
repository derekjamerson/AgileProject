using AgileProject.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Models
{
    public class AgileDbContext : DbContext
    {
        public AgileDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Character> MyProperty { get; set; }
    }
}
