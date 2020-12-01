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
    public partial class FormUjJegy : Form
    {
        Database1Entities context = new Database1Entities();
        public FormUjJegy()
        {
            InitializeComponent();
            feltolt();
            osztalyzatok();
            
            
            
        }
        private void feltolt()
        {
            listBoxTanulok.DataSource = context.Tanuloks.ToList();
            listBoxTanulok.DisplayMember = "Név";
            listBoxTanulok.ValueMember = "Id";
        }
        private void osztalyzatok()
        {
            comboBoxOsztalyzat.Items.Add(1);
            comboBoxOsztalyzat.Items.Add(2);
            comboBoxOsztalyzat.Items.Add(3);
            comboBoxOsztalyzat.Items.Add(4);
            comboBoxOsztalyzat.Items.Add(5);
        }
        private void temak()
        {
            comboBoxTema.Items.Add("Teszt");
        }
        

    }
}
