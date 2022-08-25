using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

// source: https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html

namespace PokazniPrimerRadaSaBazom
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private string myConnectionString = "server=127.0.0.1;uid=root;pwd=root;database=frizeraj";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ucitaj_klijente();
        }


        private void obrisiKlijenta(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Name);
        }
        private void ucitaj_klijente()
        {          
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);                
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * from klijent", conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                tabela.Controls.Clear();
                int row = 0;
                while (rdr.Read())
                {
                    //lbSviKlijenti.Items.Add(new KlijentKartica(new  Klijent((int)rdr[0], (string)rdr[1])));
                    Klijent novi_klijent = new Klijent((int)rdr[0], (string)rdr[1]);
                    Label tekst = new Label();
                    tekst.Text = novi_klijent.ToString();
                    Button obrisi = new Button();
                    obrisi.Text = "Obrisi";
                    obrisi.Name = "delete_" + novi_klijent.Id;
                    obrisi.Click += obrisiKlijenta;
                    Button izmeni = new Button();
                    izmeni.Text = "Izmeni";
                    izmeni.Name = "edit_" + novi_klijent.Id;
                    tabela.Controls.Add(tekst,0,row);
                    tabela.Controls.Add(obrisi,1,row);
                    tabela.Controls.Add(izmeni,2,row);
                    tabela.RowCount++;
                    row++;
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dodaj_klijenta() {

            Klijent novi_klijent = new Klijent();
            novi_klijent.Ime = txtImeKlijenta.Text;
            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(String.Format("INSERT INTO KLIJENT (ime) VALUES ('{0}');SELECT LAST_INSERT_ID();", novi_klijent.Ime), conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                novi_klijent.Id = (UInt64)rdr[0];
                lbSviKlijenti.Items.Add(novi_klijent);
                
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            dodaj_klijenta();
            
        }
    }
}
