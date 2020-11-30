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

namespace Kimlik
{
    public partial class KisiGirisForm : Form
    {
        Class1 c1 = new Class1(); 

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public KisiGirisForm()
        {
            InitializeComponent();
            limanlar.SelectedItem = "LIMAKPORT";
            FontSize.SelectedItem = "34";
        }

        private void KisiGirisForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void KisiGirisForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void KisiGirisForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void KisiGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FotoEkleButton_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)| All files(*.*)|*.*|";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    setImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tc_Click(object sender, EventArgs e)
        {

        }

        private void gorev_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FotoEkleButton_MouseHover(object sender, EventArgs e)
        {
            c1.changeColorHover(FotoEkleButton);
        }

        private void FotoEkleButton_MouseLeave(object sender, EventArgs e)
        {
            c1.changeColorLeave(FotoEkleButton);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void noktalama_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void buyuktur_Click(object sender, EventArgs e)
        {

        }

        private void kucuktur_MouseHover(object sender, EventArgs e)
        {
            c1.changeColorHover(kucuktur);
        }

        private void kucuktur_MouseLeave(object sender, EventArgs e)
        {
            c1.changeColorLeave(kucuktur);
        }

        private void buyuktur_MouseHover(object sender, EventArgs e)
        {
            c1.changeColorHover(buyuktur);
        }

        private void buyuktur_MouseLeave(object sender, EventArgs e)
        {
            c1.changeColorLeave(buyuktur);
        }

        private void yukari_MouseHover(object sender, EventArgs e)
        {
            c1.changeColorHover(yukari);
        }

        private void yukari_MouseLeave(object sender, EventArgs e)
        {
            c1.changeColorLeave(yukari);
        }

        private void asagi_MouseHover(object sender, EventArgs e)
        {
            c1.changeColorHover(asagi);
        }

        private void asagi_MouseLeave(object sender, EventArgs e)
        {
            c1.changeColorLeave(asagi);
        }

        private void guncelle_MouseHover(object sender, EventArgs e)
        {
            c1.changeColorHover(guncelle);
        }

        private void guncelle_MouseLeave(object sender, EventArgs e)
        {
            c1.changeColorLeave(guncelle);
        }

        private void arkaSayfaBtn_MouseHover(object sender, EventArgs e)
        {
            c1.changeColorHover(arkaSayfaBtn);
        }

        private void arkaSayfaBtn_MouseLeave(object sender, EventArgs e)
        {
            c1.changeColorLeaveForBottomButtons(arkaSayfaBtn);
        }

        private void anaSayfaBtn_MouseHover(object sender, EventArgs e)
        {
            c1.changeColorHover(anaSayfaBtn);
        }

        private void anaSayfaBtn_MouseLeave(object sender, EventArgs e)
        {
            c1.changeColorLeaveForBottomButtons(anaSayfaBtn);
        }

        private void anaSayfaBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void arkaSayfaBtn_Click(object sender, EventArgs e)
        {
            KisiGirisArkaSayfa kisiArkaSayfa = new KisiGirisArkaSayfa();
            kisiArkaSayfa.Show();
            this.Hide();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
           
                
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    axAcroPDF1.src = openFileDialog1.FileName;
            //}
            axAcroPDF1.src = @"C:\Users\asus\Desktop\Kimlik.pdf";
            //File.Delete(@"C: \Users\asus\Desktop\week3.pdf");
        }
    }
}
