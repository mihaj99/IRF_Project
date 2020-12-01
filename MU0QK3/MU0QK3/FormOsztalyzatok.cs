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
        Database1Entities context = new Database1Entities();
        List<Jegyek> jegyek = new List<Jegyek>();
        public FormOsztalyzatok()
        {
            InitializeComponent();
            feltolt();
            kiir();
            

        }
        public void feltolt()
        {
            foreach (var item in context.Jegyeks)
            {
                if (item.TanuloFK == FormUjJegy.akttan.Id)
                {
                    jegyek.Add(item);
                }
            }
            listBoxJegyek.DataSource = jegyek;
            listBoxJegyek.DisplayMember = "Jegy";
            listBoxJegyek.ValueMember = "Id";
        }

        public void kiir()
        {
            labelNev.Text = FormUjJegy.akttan.Név + " osztályzatai";
            foreach (var item in jegyek)
            {
                
                {

                }
            }
        }
    }
}
