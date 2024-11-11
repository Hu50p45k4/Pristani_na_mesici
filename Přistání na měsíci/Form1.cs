using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Přistání_na_měsíci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tlacitkoBrzdi_Click(object sender, EventArgs e)
        {
            double vyskaPuvodni = Convert.ToDouble(poleVyska.Text);
            double rychlostPuvodni = Convert.ToDouble(poleRychlost.Text);
            double hmotnostPalivaPuvodni = Convert.ToDouble(poleHmotnost.Text);
           
            double procentaBrzdeni = Convert.ToDouble(poleProcenta.Text);

            double brzdiciSila = 360 * procentaBrzdeni;
            double zrychleni = 1.62 - (brzdiciSila / 8000);


            double rozdilVysky = -rychlostPuvodni - (zrychleni / 2);
            double rozdilRychlosti = zrychleni;
            double rozdilHmotnosti = -brzdiciSila / 3000;

            double vyska = vyskaPuvodni + rozdilVysky;
            double rychlost = rychlostPuvodni + rozdilRychlosti;
            double hmotnostPaliva = hmotnostPalivaPuvodni + rozdilHmotnosti;

            poleVyska.Text = Convert.ToString(vyska);
            poleRychlost.Text = Convert.ToString(rychlost);

            if (hmotnostPaliva<=0)
            {
                poleHmotnost.Text = Convert.ToString(0);
                poleProcenta.Text = "0";
                poleProcenta.Enabled = false;
            }
            else
            {
                poleHmotnost.Text = Convert.ToString(hmotnostPaliva);
            }

            if (vyska <=0)
            {
                poleVyska.Text = "0";
                string zprava;
                if (rychlost<4)
                {
                    zprava = "Měkké přistání, gratulujeme";
                }
                else
                {
                    if (rychlost<=8)
                    {
                        zprava = "Tvrdé přistání";
                
                    }
                    else
                    {
                        zprava = "kosmonaut zahynul";
                    }
                }

                MessageBox.Show(zprava);

            }


        }
    }
}
