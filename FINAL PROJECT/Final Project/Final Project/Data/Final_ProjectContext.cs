using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_Project.Model;

namespace Final_Project.Data
{
    public class Final_ProjectContext : DbContext
    {
        public Final_ProjectContext (DbContextOptions<Final_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Final_Project.Model.Employee> Employee { get; set; }
    }
}
