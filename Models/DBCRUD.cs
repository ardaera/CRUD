using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_CRUD.Models
{
    public class DBCRUD: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DBCRUD;Integrated Security=True");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
