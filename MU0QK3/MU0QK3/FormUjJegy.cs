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
        public static Tanulok akttan = new Tanulok();
        public FormUjJegy()
        {
            InitializeComponent();
            feltolt();
            osztalyzatok();
            temak();
            
            
            
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

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            Tanulok akttanulo = new Tanulok();
            akttanulo =(Tanulok) listBoxTanulok.SelectedItem;
            Jegyek ujjegy = new Jegyek();
            ujjegy.Dátum = dateTimePicker1.Value;
            ujjegy.Jegy = (int)comboBoxOsztalyzat.SelectedItem;
            ujjegy.Mire =(string) comboBoxTema.SelectedItem;
            ujjegy.TanuloFK = akttanulo.Id;
            context.Jegyeks.Add(ujjegy);
            context.SaveChanges();


        }

        private void buttonOsztalyzatok_Click(object sender, EventArgs e)
        {
            akttan = (Tanulok)listBoxTanulok.SelectedItem;
            FormOsztalyzatok fo = new FormOsztalyzatok();
            fo.ShowDialog();
            
            
        }
    }
}
