using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BaseContext : DbContext
    {
        public BaseContext()
            : base("DBConnection")
        { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Messages_history> History { get; set; }
    }
}
