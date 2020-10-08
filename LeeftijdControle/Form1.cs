using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeeftijdControle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Vandaag = DateTime.Today;
            DateTime GeboorteDag = dtpBirthdate.Value;
            TimeSpan LeeftijdDagen = Vandaag - GeboorteDag;
            double leeftijd = (LeeftijdDagen.Days) / 365.25;
            double DagenDrinken = 18 * 365.25;
            double DagenResterend = DagenDrinken - LeeftijdDagen.Days;

            if (chbPassport.Checked)
            {
                if (leeftijd >= 18)
                {
                    MessageBox.Show("U mag drinken!");
                }
                else if (leeftijd >= 17)
                {
                    MessageBox.Show("U mag over " + DagenResterend + " dagen drinken!");
                }
                else
                {
                    MessageBox.Show("U mag helaas niet drinken!");
                }
            }
            else
            {
                MessageBox.Show("Voer eerst een paspoort controle uit.");
            }

            if (leeftijd >= 16)
            {
                MessageBox.Show("Je mag de film kijken");
            }
            else
            {
                MessageBox.Show("Je mag de film niet kijken");
            }
        }
    }
}
