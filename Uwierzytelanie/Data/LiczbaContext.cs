using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Uwierzytelanie.Models;

namespace Uwierzytelanie.Data
{
    public class LiczbaContext : IdentityDbContext
    {
        public LiczbaContext(DbContextOptions<LiczbaContext> options)
            : base(options)
        {
        }
        public DbSet<Class> Class { get; set; }
    }
}
