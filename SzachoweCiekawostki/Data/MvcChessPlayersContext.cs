using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SzachoweCiekawostki.Models;

namespace SzachoweCiekawostki.Data
{
    public class MvcChessPlayersContext : DbContext
    {
        public MvcChessPlayersContext(DbContextOptions<MvcChessPlayersContext> options)
        : base(options)
        {
        }
        public DbSet<ChessPlayers> ChessPlayers { get; set; }
        public DbSet<Books> Books { get; set; }
    }
}