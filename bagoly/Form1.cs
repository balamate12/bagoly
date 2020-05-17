using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bagoly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_kolcsonzes_Click(object sender, EventArgs e)
        {
            kolcsonzes nyit = new kolcsonzes();
            nyit.Show();
        }

        private void Button3_kesesek_Click(object sender, EventArgs e)
        {
            kesesek nyit = new kesesek();
            nyit.Show();
        }
    }
}
