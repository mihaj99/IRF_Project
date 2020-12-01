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
            
            
        }
        private void Kirak()
        {
            ComboBox cb = new ComboBox();
            cb.Width = 10;
            cb.Height = 25;
            cb.Top = 500;
            cb.Left = 100;
            this.Controls.Add(cb);
            /*List<Tanulok> _tanulok = new List<Tanulok>();
            _tanulok = context.Tanuloks.ToList();
            for (int i = 0; i < _tanulok.Count; i++)
            {
                int magassag = 10;
                int szelesseg = 20;
                int kezdoX = 25;
                int kezdoY = 25;
                ComboBox cb = new ComboBox();
                cb.Width = szelesseg;
                cb.Height = magassag;
                cb.Top = kezdoX;
                cb.Left =kezdoY;
                this.Controls.Add(cb);
            } */
        }

    }
}
