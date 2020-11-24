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
            listBoxNev.DataSource = context.Tanuloks.ToList();
            listBoxNev.ValueMember = "ID";
            listBoxNev.DisplayMember = "Név";
            
        }
    }
}
