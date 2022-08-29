using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokazniPrimerRadaSaBazom
{
    class DBUtil
    {

        private static MySqlConnection conn;
        private static  MySqlCommand cmd;
        private static string initalConnectionString = "server=127.0.0.1;uid=root;pwd=root;database=sys";
        private static string myConnectionString = "server=127.0.0.1;uid=root;pwd=root;database=frizeraj";
        public static void initialization() {

            try
            {
                conn = new MySqlConnection(initalConnectionString);
                conn.Open();
                // Check if DB exists?
                cmd = new MySqlCommand("SELECT COUNT(*) FROM information_schema.schemata WHERE schema_name = 'frizeraj';", conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                // Ako ne postoji baza, kreiraj tabelu
                if ((Int64)(rdr[0]) == 0)
                {
                    cmd = new MySqlCommand("CREATE SCHEMA `frizeraj`;", conn);
                    rdr.Close();
                    rdr = cmd.ExecuteReader();
                    conn.Close();
                    conn = new MySqlConnection(myConnectionString);
                    conn.Open();
                    rdr.Close();
                    cmd = new MySqlCommand(" CREATE TABLE `frizeraj`.`klijent` (     " +
                                           " `idklijent` INT NOT NULL AUTO_INCREMENT, " +
                                           " `ime` VARCHAR(45) NULL," +
                                           "PRIMARY KEY (`idklijent`));                 "
                                             , conn);
                    rdr = cmd.ExecuteReader();
                }
                else { 
                    // Inace zatvro konekciju i konektuj se na trazenu bazu da proveris da li ima tabela.
                     rdr.Close();
                     conn.Close();
                     conn = new MySqlConnection(myConnectionString);
                     conn.Open();
                     cmd = new MySqlCommand("SELECT COUNT(*) FROM information_schema.TABLES WHERE table_name ='klijent';",conn);
                     rdr = cmd.ExecuteReader();
                     rdr.Read();
                     // Ako i tabela postoji, to je to
                     if ((Int64)rdr[0] != 0)
                     {
                         conn.Close();
                         ucitaj_korisnike();
                     }
                     else {
                        rdr.Close();
                        cmd = new MySqlCommand(" CREATE TABLE `frizeraj`.`klijent` (     " +
                                          " `idklijent` INT NOT NULL AUTO_INCREMENT, " +
                                          " `ime` VARCHAR(45) NULL," +
                                          "PRIMARY KEY (`idklijent`));                 "
                                            , conn);
                        rdr = cmd.ExecuteReader();
                    }
                 }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void obrisi_klijenta_po_ID(int id)
        {

            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(String.Format("DELETE FROM `frizeraj`.`klijent` WHERE (`idklijent` = '{0}');", id), conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    

        public  static Klijent dodaj_novog_klijenta(Klijent novi_klijent)
        {
            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(String.Format("INSERT INTO FRIZERAJ.KLIJENT (ime) VALUES ('{0}');SELECT LAST_INSERT_ID();", novi_klijent.Ime), conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                novi_klijent.Id = (UInt64)rdr[0];              

                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return novi_klijent;
        }

        public static List<Klijent> ucitaj_korisnike()
        {
            List<Klijent> svi_klijenti = new List<Klijent>();
            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                cmd = new MySqlCommand("SELECT * from klijent",conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Klijent novi_klijent = new Klijent((int)rdr[0], (string)rdr[1]);
                    svi_klijenti.Add(novi_klijent);
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return svi_klijenti;

        }

    }
}
