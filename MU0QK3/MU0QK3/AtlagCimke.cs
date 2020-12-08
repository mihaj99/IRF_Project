using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MU0QK3
{
    class AtlagCimke:Label
    {
        public AtlagCimke()
        {
            this.ForeColor = Color.Blue;
            this.AutoSize = true;
            this.Font = new Font("Arial", 16, FontStyle.Bold);
        }
    }
}
