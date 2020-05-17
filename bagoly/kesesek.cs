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
    public partial class kesesek : Form
    {
        public kesesek()
        {
            InitializeComponent();
        }

        private void Kesesek_Load(object sender, EventArgs e)
        {
            Program.command.CommandText =
                "SELECT kolcsonzo.nev FROM kolcsonzo INNER JOIN kolcsonzes ON kolcsonzo.ID = kolcsonzes.kolcsonzoID " +
                "INNER JOIN konyvek ON kolcsonzes.konyvID = konyvek.Kod " +
                "WHERE DATEDIFF(CURRENT_DATE(), `kivetelDatum`) > 30 GROUP BY kolcsonzo.nev";
            try
            {
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listBox1_kesok.Items.Add(dr.GetString(0));
                        comboBox1_nev.Items.Add(dr.GetString(0));
                    }
                }
            }
            catch
            {

            }
        }

        private void ListBox1_kesok_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_nev.SelectedItem = listBox1_kesok.SelectedItem;
            listBox2_konyvek.Items.Clear();
            Program.command.CommandText =
            "SELECT konyvek.Cím FROM kolcsonzo " +
            "INNER JOIN kolcsonzes ON kolcsonzo.ID = kolcsonzes.kolcsonzoID " +
            "INNER JOIN konyvek ON kolcsonzes.konyvID = konyvek.Kod " +
            "WHERE DATEDIFF(CURRENT_DATE(), `kivetelDatum`) > 30 AND kolcsonzo.nev = '" + listBox1_kesok.SelectedItem.ToString() + "'";
            try
            {
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listBox2_konyvek.Items.Add(dr.GetString(0));
                    }
                }
            }
            catch
            {

            }
        }
    
    }
    
}
