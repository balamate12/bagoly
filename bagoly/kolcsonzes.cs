using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bagoly
{
    public partial class kolcsonzes : Form
    {
        public kolcsonzes()
        {
            InitializeComponent();
        }

        static List<string> listaadatok = new List<string>();

        private void Button1_Click(object sender, EventArgs e)
        {
            string berlo = comboBox2_kolcsonzo.SelectedItem.ToString();
            string konyv = comboBox1_konyvek.SelectedItem.ToString();
            string num = Convert.ToString(numericUpDown1_darab.Value);
            DateTime thisDate1 = DateTime.Now;

            string konyvid = "";
            string kolcsonzoid = "";

            foreach (var item in Program.konyvek)
            {
                if (item.Cim == konyv)
                {
                    konyvid = item.Kod;
                }
            }

            foreach (var item in Program.berlok)
            {
                if (item.Nev == berlo)
                {
                    kolcsonzoid = Convert.ToString(item.Id);
                }
            }

            listBox1_lista.Items.Add(berlo);
            listBox1_lista.Items.Add(konyv);

            listBox1_lista.Items.Add(konyvid);
            listBox1_lista.Items.Add(kolcsonzoid);
            listBox1_lista.Items.Add(num);

            
            listaadatok.Add(konyvid + ";" + kolcsonzoid + ";" + thisDate1.ToString("yyyy-MM-dd") + ";" + num);

        }


        private void Kolcsonzes_Load(object sender, EventArgs e)
        {
            foreach (Konyv item in Program.konyvek)
            {
                comboBox1_konyvek.Items.Add(item.Cim);
            }
            
            foreach (Berlo item in Program.berlok)
            {
                comboBox2_kolcsonzo.Items.Add(item.Nev);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listaadatok)
            {

                try
                {
                    string[] split = item.Split(';');
                    Program.command.CommandText = "INSERT INTO `kolcsonzes` (`konyvID`, `kolcsonzoID`, `kivetelDatum`, `peldany`) VALUES (@konyvID, @kolcsonzoID, @kivetelDatum, @pld);";
                    Program.command.Parameters.Clear();
                    Program.command.Parameters.AddWithValue("@konyvID", split[0]);
                    Program.command.Parameters.AddWithValue("@kolcsonzoID", Convert.ToInt32(split[1]));
                    Program.command.Parameters.AddWithValue("@kivetelDatum", split[2]);
                    Program.command.Parameters.AddWithValue("@pld", Convert.ToInt32(split[3]));
                    Program.command.ExecuteNonQuery();
                    MessageBox.Show("A listában szereplő adatokat sikeresen kiírtam az adatbázisba!");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            listBox1_lista.Items.Clear();
        }
    }

}
