using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Jurasssic_World.Data;

namespace Jurasssic_World.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Jurasssic_World.Data.Dinosaurs> Dinosaurs { get; set; }
        public DbSet<Jurasssic_World.Data.Exhibits> Exhibits { get; set; }
    }
}
