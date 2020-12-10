using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public Jegyek aktjegy = new Jegyek();
        List<Jegyek> jegyek2 = new List<Jegyek>();
        

        public FormUjJegy()
        {
            InitializeComponent();
            feltolt();
            osztalyzatok();
            temak();
            
            
            listBoxTanulok.SelectedIndexChanged += ListBoxTanulok_SelectedIndexChanged;
            listBoxJegyek.SelectedIndexChanged += ListBoxJegyek_SelectedIndexChanged;
            textBoxKereses.TextChanged += TextBoxKereses_TextChanged;
            
            
        }

        private void TextBoxKereses_TextChanged(object sender, EventArgs e)
        {
            feltolt();
        }

        private void ListBoxJegyek_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktjegy=(Jegyek)listBoxJegyek.SelectedItem;
            foreach (var item in jegyek2)
            {
                if (item.Id==aktjegy.Id)
                {
                    labelDat.Text = item.Dátum.ToString();
                    labelTem.Text = item.Mire;
                }
            }
        }

        private void ListBoxTanulok_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            akttan = (Tanulok)listBoxTanulok.SelectedItem;
            
            jegyfeltolt();
            labelCim.Text = String.Format("{0} osztályzatai", akttan.Név);
            
        }

        private void feltolt()
        {
            var ker_eredmeny = (from x in context.Tanuloks
                                where x.Név.Contains(textBoxKereses.Text)
                                select x);
            listBoxTanulok.DataSource = ker_eredmeny.ToList();
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

        public void jegyfeltolt()
        {

            List<Jegyek> jegyek = new List<Jegyek>();

            foreach (var item in context.Jegyeks)
            {
                if (item.TanuloFK == akttan.Id)
                {
                    jegyek.Add(item);
                }
            }
            listBoxJegyek.DataSource = jegyek;
            listBoxJegyek.DisplayMember = "Jegy";
            listBoxJegyek.ValueMember = "Id";
            jegyek2 = jegyek;
            

        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            if (comboBoxOsztalyzat.SelectedItem!=null)
            {
                if (comboBoxTema.SelectedItem != null)
                {
                    Tanulok akttanulo = new Tanulok();
                    akttanulo = (Tanulok)listBoxTanulok.SelectedItem;
                    Jegyek ujjegy = new Jegyek();
                    ujjegy.Dátum = dateTimePicker1.Value;
                    ujjegy.Jegy = (int)comboBoxOsztalyzat.SelectedItem;
                    ujjegy.Mire = (string)comboBoxTema.SelectedItem;
                    ujjegy.TanuloFK = akttanulo.Id;
                    context.Jegyeks.Add(ujjegy);
                    context.SaveChanges();
                    jegyfeltolt();
                }
                else
                {
                    MessageBox.Show("Válasszon témát!");
                }
            }
            else
            {
                MessageBox.Show("Válasszon jegyet!");
            }
            


        }

        private void buttonOsztalyzatok_Click(object sender, EventArgs e)
        {

            



        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (listBoxJegyek.SelectedItem!=null)
            {
                context.Jegyeks.Remove(aktjegy);
                context.SaveChanges();
                jegyfeltolt();
            }
            else
            {
                MessageBox.Show("Válasszon jegyet!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName, Encoding.UTF8);

                string[] sor = sr.ReadLine().Split(',');

                foreach (var item in sor)
                {
                    comboBoxTema.Items.Add(item);
                }
            }
            
            

                
            
            


            
        }
    }
}
