using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ilie_Adrian_Lab2.Models;

namespace Ilie_Adrian_Lab2.Data
{
    public class Ilie_Adrian_Lab2Context : DbContext
    {
        public Ilie_Adrian_Lab2Context (DbContextOptions<Ilie_Adrian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ilie_Adrian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ilie_Adrian_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Ilie_Adrian_Lab2.Models.Author> Author { get; set; }

        public DbSet<Ilie_Adrian_Lab2.Models.Category> Category { get; set; }
    }
}
