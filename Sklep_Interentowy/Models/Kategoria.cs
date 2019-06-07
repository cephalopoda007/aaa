using System.Collections;
using System.Collections.Generic;

namespace Sklep_Interentowy.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string NazwaKategori { get; set; }
        public string OpisKategori { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Kurs> Kursy { get; set; }
        string dupa; 

    }
}