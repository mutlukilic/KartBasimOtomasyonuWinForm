using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimlik
{
    class Class1
    {
        public void changeColorHover(Button b)
        {
            b.ForeColor = Color.White;
            b.BackColor = Color.DarkTurquoise;
        }
        public void changeColorLeave(Button b)
        {
            b.ForeColor = Color.Black;
            b.BackColor = Color.Silver;
        }
        public void changeColorLeaveForBottomButtons(Button b)
        {
            b.ForeColor = Color.Black;
            b.BackColor = Color.White;
        }
    }
}
