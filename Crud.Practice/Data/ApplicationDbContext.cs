using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Crud.Practice.Models;

namespace Crud.Practice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Crud.Practice.Models.Blog> Blog { get; set; }
        public DbSet<Crud.Practice.Models.Post> Post { get; set; }
    }
}
