using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokazniPrimerRadaSaBazom
{
    class KlijentKartica : Panel
    {
        private Klijent klijent;
        private Label tekst = new Label();
        private Button btnObrisi = new Button();
        private Button btnIzmeni = new Button();
        public KlijentKartica(Klijent model) {

            this.klijent = model;
            
            this.tekst.Text = this.klijent.ToString();
            //this.btnObrisi.Click += obrisiKlijenta;
            this.Controls.Add(tekst);
            this.Controls.Add(btnObrisi);
            this.Controls.Add(btnIzmeni);
        }

      
    }
}
