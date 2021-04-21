using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SzachoweCiekawostki.Models;

namespace SzachoweCiekawostki.Data
{
   
        public class MvcBooksContext : DbContext
        {
            public MvcBooksContext(DbContextOptions<MvcBooksContext> options)
            : base(options)
            {
            }
            public DbSet<Books> Books { get; set; }
        }
    }
