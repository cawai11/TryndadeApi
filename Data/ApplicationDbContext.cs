using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TryndadeApi.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }


    }
}
