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
    public partial class FormAtlagok : Form
    {
        
        List<atlag> atlagok = new List<atlag>();
        public static List<VegsoJegy> vegsojegyek = new List<VegsoJegy>();

        int szamlalo;
        int maxhossz = 0;
        
        

        Database1Entities context = new Database1Entities();
        double osszeg = 0;
        double darabszam = 0;




        public FormAtlagok()
        {
            InitializeComponent();
            Atlagszamitas();
            Diagram();
            NevekKiir();
            MaximumHossz();
            AtlagKiir();
            panel1.AutoScroll = true;
        }

        private void AtlagKiir()
        {
            szamlalo = 0;
            foreach (var item in atlagok)
            {
                AtlagCimke lbl = new AtlagCimke();
                lbl.Text = item.Atlag.ToString();
                lbl.Left = 1+maxhossz+30;
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
                if (item.Width>maxhossz)
                {
                    maxhossz = item.Width;
                }
            }
            
            
        }

        private void NevekKiir()
        {
            szamlalo = 0;
            foreach (var item in atlagok)
            {
                AtlagCimke lbl = new AtlagCimke();
                lbl.Text = item.nev;
                lbl.Left = 1+maxhossz;
                lbl.Top = 1 + szamlalo * lbl.Height;
                panel1.Controls.Add(lbl);
                szamlalo++;

            }
        }
        

        private void Diagram()
        {
            chartAtlagok.DataSource = atlagok;
            var series = chartAtlagok.Series[0];
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series.XValueMember = "nev";
            series.YValueMembers = "atlag";
            series.BorderWidth = 2;
            

            var legend = chartAtlagok.Legends[0];
            legend.Enabled = false;

            var chartArea = chartAtlagok.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisY.Minimum = 1;
            chartArea.AxisY.Maximum = 5;
        }

        private void Atlagszamitas()
        {
            foreach (var tanulo in context.Tanuloks)
            {
                osszeg = 0;
                darabszam = 0;

                foreach (var jegy in context.Jegyeks)
                {
                    if (jegy.TanuloFK == tanulo.Id)
                    {
                        osszeg += (int)jegy.Jegy;
                        darabszam += 1;
                    }

                }

                atlag ujatlag = new atlag();
                ujatlag.ID = tanulo.Id;
                ujatlag.nev = tanulo.Név;
                ujatlag.Atlag = Math.Round(osszeg / darabszam,2);
                atlagok.Add(ujatlag);

            }
        }

        private void buttonOsztalyzatok_Click(object sender, EventArgs e)
        {
            vegsojegyek.Clear();

            foreach (atlag item in atlagok)
            {
                VegsoJegy uj = new VegsoJegy();
                uj.ID = item.ID;
                uj.Nev = item.nev;
                uj.Osztalyzat = item.Atlag;
                vegsojegyek.Add(uj);
            }
            FormOsztalyzatok fo = new FormOsztalyzatok();
            fo.ShowDialog();
        }

    
    }
}
