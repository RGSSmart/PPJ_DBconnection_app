using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokazniPrimerRadaSaBazom
{
    class Klijent
    {
        public UInt64 Id { get; set; }
        public string Ime { get; set; } 
        public Klijent(int id, string ime) {
            this.Id = (UInt64)id;
            this.Ime = ime;
        }
        public Klijent() { }

        override
        public string ToString() {
            return "Klijent: " + this.Id + ". " + this.Ime; 
        }
    }
}
