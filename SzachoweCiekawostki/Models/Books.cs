using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SzachoweCiekawostki.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Tytuł { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataWydania { get; set; }
        public string Autor { get; set; }
        public decimal Cena { get; set; }

    }
}
