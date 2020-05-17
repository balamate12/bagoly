using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagoly
{
    class Konyv
    {
        private string kod;
        private string szerzo;
        private string cim;
        private int kiadaseve;
        private int ar;
        private string isbn;

        public string Kod { get => kod; set => kod = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Kiadaseve { get => kiadaseve; set => kiadaseve = value; }
        public int Ar { get => ar; set => ar = value; }
        public string Isbn { get => isbn; set => isbn = value; }

        public Konyv(string kod, string szerzo, string cim, int kiadaseve, int ar, string isbn)
        {
            this.Kod = kod;
            this.Szerzo = szerzo;
            this.Cim = cim;
            this.Kiadaseve = kiadaseve;
            this.Ar = ar;
            this.Isbn = isbn;
        }
    }
}
