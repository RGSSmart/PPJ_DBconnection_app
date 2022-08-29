using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokazniPrimerRadaSaBazom
{
    class KlijentKartica
    {
        Klijent klijent;
        Button obrisi;
        Button izmeni;
        Label tekst;
        public KlijentKartica(Klijent model, Button obrisi, Button izmeni, Label tekst) {
            this.klijent = model;
            this.obrisi = obrisi;
            this.izmeni = izmeni;
            this.tekst = tekst;
        }
    }

}
