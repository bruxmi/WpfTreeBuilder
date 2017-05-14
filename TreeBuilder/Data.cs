using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBuilder
{
    public class Data
    {
        public int Id { get; set; }
        public string Bezeichnung => $"{Kategorie}-{Kundenart}-{Sparte}-{Status}";
        public string Kategorie { get; set; }
        public string Kundenart { get; set; }
        public string Sparte { get; set; }
        public string Status { get; set; }
    }
}
