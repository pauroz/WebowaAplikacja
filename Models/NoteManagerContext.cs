using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebowaAplikacja.Models
{
    public class NoteManagerContext : DbContext
    {
        public NoteManagerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ClassWebApp> Notes { get; set; }
    }
}
