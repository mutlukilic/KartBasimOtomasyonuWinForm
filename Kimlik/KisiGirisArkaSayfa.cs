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
    public partial class KisiGirisArkaSayfa : Form
    {
        Class1 c1 = new Class1();
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public KisiGirisArkaSayfa()
        {
            InitializeComponent(); 
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void arkaSayfaBtn_Click(object sender, EventArgs e)
        {
            KisiGirisForm kisi = new KisiGirisForm();
            kisi.Show();
            this.Hide();
        }

        private void anaSayfaBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void KisiGirisArkaSayfa_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void KisiGirisArkaSayfa_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void KisiGirisArkaSayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void KisiGirisArkaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GuncelleBtn_MouseHover(object sender, EventArgs e)
        {
            c1.changeColorHover(GuncelleBtn);
        }

        private void GuncelleBtn_MouseLeave(object sender, EventArgs e)
        {
            c1.changeColorLeaveForBottomButtons(GuncelleBtn);
        }

        private void AracPlakasıTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeriNotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            axAcroPDF1.src = @"C:\Users\asus\Desktop\Kimlik.pdf";
        }
    }
}
