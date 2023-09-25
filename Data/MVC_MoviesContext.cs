using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MVC_Movies.Data
{
    public class MVC_MoviesContext : DbContext
    {
        public MVC_MoviesContext (DbContextOptions<MVC_MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
