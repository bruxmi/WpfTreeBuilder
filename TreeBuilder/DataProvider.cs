using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBuilder
{
    public class DataProvider
    {
        public List<Data> GetData()
        {
            var list = new List<Data>
            {
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },

                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "Aktiv" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "InBearbeitung" },
                new Data { Kategorie = "VESALES", Kundenart = "Gewerbe", Sparte = "Gas", Status = "InBearbeitung" },

                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "InBearbeitung" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
                new Data { Kategorie = "VREES", Kundenart = "Privat", Sparte = "Strom", Status = "Aktiv" },
            };

            var count = 1;
            foreach (var item in list)
            {
                item.Id = count;
                count++;
            }

            return list;
        }
    }
}
