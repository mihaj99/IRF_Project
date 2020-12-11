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
    public partial class FormUjTanulo : Form
    {
        Database1Entities context = new Database1Entities();
        Tanulok akttan = new Tanulok();
        public FormUjTanulo()
        {
            InitializeComponent();
            checkBoxSNIKijelez.Enabled = false;
            buttonTorles.Enabled = false;
            Feltolt();
        }

        private void Feltolt()
        {
            var ker_eredmeny = (from x in context.Tanuloks
                                where x.Név.Contains(textBoxKereses.Text)
                                select x);
            listBoxTanulok.DataSource = ker_eredmeny.ToList();
            listBoxTanulok.DisplayMember = "Név";
            listBoxTanulok.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Tanulok uj = new Tanulok();
            if (txtNev.Text=="")
            {
                MessageBox.Show("Név megadása kötelező!");
                
                return;
            }
            
            uj.Név = txtNev.Text;
            uj.Születési_dátum =dateTimeSzuldat.Value;
            uj.SNI = chbSNI.Checked;
            context.Tanuloks.Add(uj);
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba a mentés során!");
            }
            
            Feltolt();
        }

        private void textBoxKereses_TextChanged(object sender, EventArgs e)
        {
            Feltolt();
        }

        private void listBoxTanulok_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            akttan = (Tanulok)listBoxTanulok.SelectedItem;
            labelNevKijelez.Text = akttan.Név;
            labelSzuldatKijelez.Text = akttan.Születési_dátum.ToString().Remove(akttan.Születési_dátum.ToString().Length-8);
            checkBoxSNIKijelez.Checked =(bool) akttan.SNI;
            buttonTorles.Enabled = true;

        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            foreach (Jegyek item in context.Jegyeks)
            {
                if (item.TanuloFK==akttan.Id)
                {
                    context.Jegyeks.Remove(item);
                    

                }
            }
            context.Tanuloks.Remove(akttan);

            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba a mentés során!");
            }
            
            Feltolt();
        }
    }
}
