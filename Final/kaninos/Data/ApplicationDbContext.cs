using System;
using Microsoft.EntityFrameworkCore;
using kaninos.Entities;

namespace kaninos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Criador> Criadores { get; set; }
    }
}