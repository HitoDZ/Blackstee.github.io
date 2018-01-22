using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemsMVC
{
    public class MemesContext : DbContext
    {
        public MemesContext(DbContextOptions<MemesContext> options) : base(options) { }

        public DbSet<Models.Meme> Memes { get; set; }
    }
}
