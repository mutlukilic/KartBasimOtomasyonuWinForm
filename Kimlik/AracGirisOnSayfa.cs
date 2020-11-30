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
    public partial class AracGirisOnSayfa : Form
    {
        public AracGirisOnSayfa()
        {
            InitializeComponent();
        }

        private void AracGirisOnSayfa_Load(object sender, EventArgs e)
        {
            limanlararac.SelectedItem = "LIMAKPORT";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            axAcroPDF1.src = @"C:\Users\asus\Desktop\Kimlik.pdf";
        }

        private void arkaSayfaBtn_Click(object sender, EventArgs e)
        {
            AracGirisArkaSayfa aracGirisarka = new AracGirisArkaSayfa();
            aracGirisarka.Show();
            this.Hide();
        }
    }
}
