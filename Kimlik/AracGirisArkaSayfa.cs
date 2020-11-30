using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimlik
{
    public partial class AracGirisArkaSayfa : Form
    {
        public AracGirisArkaSayfa()
        {
            InitializeComponent();
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            axAcroPDF1.src = @"C:\Users\asus\Desktop\Kimlik2.pdf";
        }
    }
}
