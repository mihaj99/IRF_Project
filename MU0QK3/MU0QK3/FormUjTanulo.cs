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
        public FormUjTanulo()
        {
            InitializeComponent(); 
            
            
            
        }
        

        private void FormUjTanulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Tanulok uj = new Tanulok();
            if (txtNev.Text=="")
            {
                MessageBox.Show("Név megadása kötelező!");
                txtNev.Focus();
                return;
            }
            
            uj.Név = txtNev.Text;
            uj.Születési_dátum = dateTimeSzuldat.Value;
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
            MessageBox.Show("Felvitel OK!");
        }
    }
}
