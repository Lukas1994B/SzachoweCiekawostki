using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SzachoweCiekawostki.Models
{
    public class ChessPlayers
    {
        public int Id { get; set; }
        public string ImieNazwisko { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataUrodzenia { get; set; }
        public string Klub { get; set; }
        public int Ranking { get; set; }
    }

}
