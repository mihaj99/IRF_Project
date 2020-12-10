using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MU0QK3
{
    public partial class FormOsztalyzatok : Form
    {
        int szamlalo;
        int maxhossz = 0;
        public FormOsztalyzatok()
        {
            InitializeComponent();
            
           
            NevekKiir();
            MaximumHossz();
            JegyKiir();
            panel1.AutoScroll = true;

        }
        private void JegyKiir()
        {


            szamlalo = 0;
            foreach (var item in FormAtlagok.vegsojegyek)
            {
                AtlagCimke lbl = new AtlagCimke();
                lbl.Text = item.Osztalyzat.ToString();
                lbl.Left = 1 + maxhossz + 30;
                lbl.Top = 1 + szamlalo * lbl.Height;
                panel1.Controls.Add(lbl);
                szamlalo++;

            }
        }

        private void MaximumHossz()
        {
            maxhossz = 0;

            foreach (AtlagCimke item in panel1.Controls)
            {


                if (item.Width > maxhossz)
                {
                    maxhossz = item.Width;
                }
            }


        }

        private void NevekKiir()
        {


            szamlalo = 0;
            foreach (var item in FormAtlagok.vegsojegyek)
            {
                AtlagCimke lbl = new AtlagCimke();
                lbl.Text = item.Nev;
                lbl.Left = 1 + maxhossz;
                lbl.Top = 1 + szamlalo * lbl.Height;
                panel1.Controls.Add(lbl);
                szamlalo++;

            }
        }
        
    }
}
