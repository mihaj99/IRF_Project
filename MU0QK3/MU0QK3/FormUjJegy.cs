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
        BindingList<Jegyek> jegyek = new BindingList<Jegyek>();
        



        public FormUjJegy()
        {
            InitializeComponent();
            buttonTorles.Enabled= false;
            listBoxJegyek.DataSource = jegyek;
            listBoxJegyek.DisplayMember = "Jegy";
            listBoxJegyek.ValueMember = "Id";
            Feltolt();
            Osztalyzatok();
            Temak();
            
            listBoxTanulok.SelectedIndexChanged += ListBoxTanulok_SelectedIndexChanged;
            listBoxJegyek.SelectedIndexChanged += ListBoxJegyek_SelectedIndexChanged;
            textBoxKereses.TextChanged += TextBoxKereses_TextChanged;
            
            
        }

        private void TextBoxKereses_TextChanged(object sender, EventArgs e)
        {
            Feltolt();
        }

        private void ListBoxJegyek_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            aktjegy =(Jegyek)listBoxJegyek.SelectedItem;
            foreach (var item in jegyek)
            {
                if (item.Id==aktjegy.Id)
                {
                    labelDat.Text = item.Dátum.Value.Date.ToString();
                    labelTem.Text = item.Mire;
                    buttonTorles.Enabled = true;
                }
            }
            

        }

        private void ListBoxTanulok_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonTorles.Enabled = false;
            labelDat.Text = "";
            labelTem.Text = "";
            akttan = (Tanulok)listBoxTanulok.SelectedItem;
            Jegyfeltolt();
            labelCim.Text = String.Format("{0} osztályzatai", akttan.Név);
            

        }

        private void Temak()
        {
            StreamReader sr = new StreamReader("temak.txt", Encoding.UTF8);
            string[] sor = sr.ReadLine().Split(',');
            foreach (var item in sor)
            {
                comboBoxTema.Items.Add(item);
            }
            sr.Close();
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
        private void Osztalyzatok()
        {
            comboBoxOsztalyzat.Items.Add(1);
            comboBoxOsztalyzat.Items.Add(2);
            comboBoxOsztalyzat.Items.Add(3);
            comboBoxOsztalyzat.Items.Add(4);
            comboBoxOsztalyzat.Items.Add(5);
        }
        

        public void Jegyfeltolt()
        { 
            jegyek.Clear();

            foreach (var item in context.Jegyeks)
            {
                if (item.TanuloFK == akttan.Id)
                {
                    jegyek.Add(item);
                }
            }

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
                    Jegyfeltolt();
                }
                else
                {
                    MessageBox.Show(this,"Válasszon témát!","Adatfelviteli hiba!");
                }
            }
            else
            {
                MessageBox.Show("Válasszon jegyet!");
            }
        }

        

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            
                context.Jegyeks.Remove(aktjegy);
                context.SaveChanges();
                Jegyfeltolt();
                buttonTorles.Enabled = false; 
            
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
