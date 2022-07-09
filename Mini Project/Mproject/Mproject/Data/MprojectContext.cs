using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mproject.Model;

namespace Mproject.Data
{
    public class MprojectContext : DbContext
    {
        public MprojectContext (DbContextOptions<MprojectContext> options)
            : base(options)
        {
        }

        public DbSet<Mproject.Model.Product> Product { get; set; }
    }
}
