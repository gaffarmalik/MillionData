using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Bogus_MVC_.Models;

namespace Bogus_MVC_.Data
{
    public partial class Bogus_App_DBContext : DbContext
    {
        public Bogus_App_DBContext()
        {
        }

        public Bogus_App_DBContext(DbContextOptions<Bogus_App_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; } = null!;

       
    }
}
