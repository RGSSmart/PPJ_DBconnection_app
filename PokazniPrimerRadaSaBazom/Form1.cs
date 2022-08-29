using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

// source: https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html

namespace PokazniPrimerRadaSaBazom
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            DBUtil.initialization();
        }
        private static void obrisiKlijenta(object sender, EventArgs e)
        {
            //((Button)sender).Name
                var target = ((Button)sender).Name;
                target = target.Split('_')[1];
            if (MessageBox.Show("Da li zelite da obrisete klijenta sa ID-em " + target + "?", "Brisanje klijenta", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                DBUtil.obrisi_klijenta_po_ID(int.Parse(target));
                
            }
        }
        private void prikazi_klijente_iz_baze() {

            var result = DBUtil.ucitaj_korisnike();
            tabela.Controls.Clear();
            int row = 2;
            foreach (var res in result)
            {
                Label tekst = new Label();
                tekst.Text = res.ToString();
                Button obrisi = new Button();
                obrisi.Text = "Obrisi";
                obrisi.Name = "delete_" + res.Id;
                obrisi.Click += obrisiKlijenta;
                Button izmeni = new Button();
                izmeni.Text = "Izmeni";
                izmeni.Name = "edit_" + res.Id;
                tabela.Controls.Add(tekst,  0, row);
                tabela.Controls.Add(obrisi, 1, row);
                tabela.Controls.Add(izmeni, 2, row);
                tabela.RowCount++;
                row++;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            prikazi_klijente_iz_baze();

        }
        public void dodaj_klijenta() 
        {

            Klijent novi_klijent = new Klijent();
            novi_klijent.Ime = txtImeKlijenta.Text;
            novi_klijent = DBUtil.dodaj_novog_klijenta(novi_klijent);
            prikazi_klijente_iz_baze();
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            dodaj_klijenta();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prikazi_klijente_iz_baze();
        }
    }
}
