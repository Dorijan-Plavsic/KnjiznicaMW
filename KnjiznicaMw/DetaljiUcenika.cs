using System;
using System.IO;
using System.Windows.Forms;

namespace KnjiznicaMw
{
    public partial class DetaljiUcenika : Form
    {
        public DetaljiUcenika()
        {
            InitializeComponent();
        }

        private void btnDodajUcenika_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Ucenici\\" + tbIme.Text + " " + tbPrezime.Text + ".txt");

            sw.WriteLine(tbOIB.Text + "|" + tbIme.Text + "|" + tbPrezime.Text + "|" + tbAdresa.Text + "|" + tbTelefon.Text + "|" + cbRazred.Text);
            sw.Close();
            
            

            

        }
    }
}
