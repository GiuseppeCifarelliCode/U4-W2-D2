using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaImmobiliare
{
    internal class Appartamento
    {
        public int nVani { get; set; }
        public string giardinoTerrazza { get; set; }

        public string tipoAppartamento { get; set; }

        public double metriQ { get; set; }

        public string zona { get; set; }

        public double prezzo;

        public Appartamento() { }

        public Appartamento(int nVani, string giardinoTerrazza, string tipoAppartamento, double metriQ, string zona)
        {
            this.nVani = nVani;
            this.giardinoTerrazza = giardinoTerrazza;
            this.tipoAppartamento = tipoAppartamento;
            this.metriQ = metriQ;
            this.zona = zona;
        }
    }
}
