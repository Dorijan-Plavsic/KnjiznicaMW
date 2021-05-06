using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnjiznicaMw
{
    public partial class Knjiznica : Form
    {
    

        public Knjiznica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUcenici_Click(object sender, EventArgs e)
        {

            Ucenici ucenici = new Ucenici();
            this.Hide();
            ucenici.ShowDialog();
            this.Show();

        }

        private void btnKnjige_Click(object sender, EventArgs e)
        {
            Knjige knjige = new Knjige();
            this.Hide();
            knjige.ShowDialog();
            this.Show();
        }
    }
}
