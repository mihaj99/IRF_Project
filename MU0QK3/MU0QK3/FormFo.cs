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
    public partial class FormFo : Form
    {
        public FormFo()
        {
            InitializeComponent();
        }

        private void btnUjTanulo_Click(object sender, EventArgs e)
        {
            FormUjTanulo FUT = new FormUjTanulo();
            FUT.ShowDialog();
            //this.Visible = false;
        }

        private void btnJegyek_Click(object sender, EventArgs e)
        {
            FormUjJegy FUJ = new FormUjJegy();
            FUJ.ShowDialog();
        }

        private void buttonAtlagok_Click(object sender, EventArgs e)
        {
            FormAtlagok fa = new FormAtlagok();
            fa.ShowDialog();
        }
    }
}
