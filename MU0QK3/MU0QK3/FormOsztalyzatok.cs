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
        List<Jegyek> _jegyek = new List<Jegyek>();
        
        
        public FormOsztalyzatok()
        {
            InitializeComponent();
            foreach (var item in context.Jegyeks)
            {
                if (item.TanuloFK==FormUjJegy.akttan.Id)
                {
                    _jegyek.Add(item);
                }
            }
            listBox1.DataSource = _jegyek;
            listBox1.DisplayMember = "Jegy";
            listBox1.ValueMember = "Id";
            
        }
    }
}
