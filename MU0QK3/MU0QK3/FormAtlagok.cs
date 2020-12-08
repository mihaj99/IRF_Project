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
        List<atlagok> _atlagok = new List<atlagok>();
        List<Tanulok> _tanulok = new List<Tanulok>();
        List<Jegyek> _jegyek = new List<Jegyek>();
        int szamlalo = 0;

        Database1Entities context = new Database1Entities();
        double osszeg = 0;
        double darabszam = 0;




        public FormAtlagok()
        {
            InitializeComponent();



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

                atlagok ujatlag = new atlagok();
                ujatlag.ID = tanulo.Id;
                ujatlag.nev = tanulo.Név;
                ujatlag.atlag = osszeg / darabszam;
                _atlagok.Add(ujatlag);

            }
            chartAtlagok.DataSource = _atlagok;
            var series = chartAtlagok.Series[0];
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.XValueMember = "nev";
            series.YValueMembers = "atlag";
            series.BorderWidth = 2;

            var legend = chartAtlagok.Legends[0];
            legend.Enabled = false;

            var chartArea = chartAtlagok.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;

            this.Controls.Add(chartAtlagok);


            foreach (var item in _atlagok)
            {
                Label lbl = new Label();
                lbl.Text = item.nev;
                lbl.Left = 1;
                lbl.Top = 1 + szamlalo * lbl.Height;
                panel1.Controls.Add(lbl);
                szamlalo++;

            }
        }
    }
}
