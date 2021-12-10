using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ems.DataBase
{
    public class EmsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public EmsContext() : base("DBConnection")
        {

        }
    }
}
