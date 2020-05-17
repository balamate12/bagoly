using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bagoly
{
    static class Program
    {
        public static MySqlConnection conn = null;
        public static MySqlCommand command = null;
        public static List<Konyv> konyvek = new List<Konyv>();
        public static List<Berlo> berlok = new List<Berlo>();


        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.Database = "bagolyvarka";
            sb.UserID = "root";
            sb.Password = "";
            sb.CharacterSet = "UTF8";

            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                command = conn.CreateCommand();
                Konyvtoltes();
                Berlotoltes();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void Konyvtoltes()
        {
            command.CommandText = "SELECT * FROM `konyvek`";
            try
            {
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Konyv konyv = new Konyv(dr.GetString("Kod"), dr.GetString("Szerzo"), dr.GetString("Cím"), dr.GetInt32("KiadasEve"), dr.GetInt32("Ar"), dr.GetString("ISBN"));
                        konyvek.Add(konyv);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        static void Berlotoltes()
        {
            command.CommandText = "SELECT * FROM `kolcsonzo`";
            try
            {
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Berlo berlo = new Berlo(dr.GetInt32("id"), dr.GetString("nev"));
                        berlok.Add(berlo);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }


}
