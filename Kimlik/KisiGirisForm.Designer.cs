namespace Kimlik
{
    partial class KisiGirisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiGirisForm));
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.setImage = new System.Windows.Forms.PictureBox();
            this.FotoEkleButton = new System.Windows.Forms.Button();
            this.limanlar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TctextBox = new System.Windows.Forms.TextBox();
            this.GorevtextBox = new System.Windows.Forms.TextBox();
            this.KurumtextBox = new System.Windows.Forms.TextBox();
            this.SoyaditextBox = new System.Windows.Forms.TextBox();
            this.AditextBox = new System.Windows.Forms.TextBox();
            this.tahdit = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.Label();
            this.gorev = new System.Windows.Forms.Label();
            this.kurum = new System.Windows.Forms.Label();
            this.soyadi = new System.Windows.Forms.Label();
            this.adi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.asagi = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Label();
            this.yukari = new System.Windows.Forms.Button();
            this.buyuktur = new System.Windows.Forms.Button();
            this.kucuktur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.noktalama = new System.Windows.Forms.Label();
            this.guncelle = new System.Windows.Forms.Button();
            this.arkaSayfaBtn = new System.Windows.Forms.Button();
            this.anaSayfaBtn = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.setImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(440, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 25);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minimize.ForeColor = System.Drawing.Color.Black;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(406, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(28, 25);
            this.minimize.TabIndex = 4;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // setImage
            // 
            this.setImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setImage.Image = ((System.Drawing.Image)(resources.GetObject("setImage.Image")));
            this.setImage.Location = new System.Drawing.Point(17, 46);
            this.setImage.Name = "setImage";
            this.setImage.Size = new System.Drawing.Size(132, 159);
            this.setImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setImage.TabIndex = 4;
            this.setImage.TabStop = false;
            // 
            // FotoEkleButton
            // 
            this.FotoEkleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FotoEkleButton.BackColor = System.Drawing.Color.Silver;
            this.FotoEkleButton.ForeColor = System.Drawing.Color.Black;
            this.FotoEkleButton.Location = new System.Drawing.Point(17, 211);
            this.FotoEkleButton.Name = "FotoEkleButton";
            this.FotoEkleButton.Size = new System.Drawing.Size(132, 32);
            this.FotoEkleButton.TabIndex = 5;
            this.FotoEkleButton.Text = "Fotoğraf Ekle";
            this.FotoEkleButton.UseVisualStyleBackColor = false;
            this.FotoEkleButton.Click += new System.EventHandler(this.FotoEkleButton_Click);
            this.FotoEkleButton.MouseLeave += new System.EventHandler(this.FotoEkleButton_MouseLeave);
            this.FotoEkleButton.MouseHover += new System.EventHandler(this.FotoEkleButton_MouseHover);
            // 
            // limanlar
            // 
            this.limanlar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.limanlar.BackColor = System.Drawing.Color.Silver;
            this.limanlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.limanlar.FormattingEnabled = true;
            this.limanlar.Items.AddRange(new object[] {
            "LIMAKPORT",
            "TUM LIMANLAR"});
            this.limanlar.Location = new System.Drawing.Point(17, 249);
            this.limanlar.Name = "limanlar";
            this.limanlar.Size = new System.Drawing.Size(132, 21);
            this.limanlar.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Controls.Add(this.FontSize);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.TctextBox);
            this.groupBox1.Controls.Add(this.GorevtextBox);
            this.groupBox1.Controls.Add(this.KurumtextBox);
            this.groupBox1.Controls.Add(this.SoyaditextBox);
            this.groupBox1.Controls.Add(this.AditextBox);
            this.groupBox1.Controls.Add(this.tahdit);
            this.groupBox1.Controls.Add(this.tc);
            this.groupBox1.Controls.Add(this.gorev);
            this.groupBox1.Controls.Add(this.kurum);
            this.groupBox1.Controls.Add(this.soyadi);
            this.groupBox1.Controls.Add(this.adi);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(152, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİLER";
            // 
            // FontSize
            // 
            this.FontSize.BackColor = System.Drawing.Color.Silver;
            this.FontSize.DisplayMember = "34";
            this.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSize.FormattingEnabled = true;
            this.FontSize.Items.AddRange(new object[] {
            "34",
            "33",
            "32",
            "31",
            "30",
            "29",
            "28",
            "27",
            "26",
            "25",
            "24",
            "23",
            "22",
            "21",
            "20",
            "19",
            "18",
            "17",
            "16",
            "15"});
            this.FontSize.Location = new System.Drawing.Point(237, 60);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(37, 21);
            this.FontSize.TabIndex = 15;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(233, 139);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(191, 139);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(153, 139);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(115, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TctextBox
            // 
            this.TctextBox.Location = new System.Drawing.Point(115, 113);
            this.TctextBox.Name = "TctextBox";
            this.TctextBox.Size = new System.Drawing.Size(159, 20);
            this.TctextBox.TabIndex = 10;
            // 
            // GorevtextBox
            // 
            this.GorevtextBox.Location = new System.Drawing.Point(115, 87);
            this.GorevtextBox.Name = "GorevtextBox";
            this.GorevtextBox.Size = new System.Drawing.Size(159, 20);
            this.GorevtextBox.TabIndex = 9;
            this.GorevtextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // KurumtextBox
            // 
            this.KurumtextBox.Location = new System.Drawing.Point(115, 61);
            this.KurumtextBox.Name = "KurumtextBox";
            this.KurumtextBox.Size = new System.Drawing.Size(119, 20);
            this.KurumtextBox.TabIndex = 8;
            this.KurumtextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SoyaditextBox
            // 
            this.SoyaditextBox.Location = new System.Drawing.Point(115, 35);
            this.SoyaditextBox.Name = "SoyaditextBox";
            this.SoyaditextBox.Size = new System.Drawing.Size(159, 20);
            this.SoyaditextBox.TabIndex = 7;
            this.SoyaditextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AditextBox
            // 
            this.AditextBox.Location = new System.Drawing.Point(115, 9);
            this.AditextBox.Name = "AditextBox";
            this.AditextBox.Size = new System.Drawing.Size(159, 20);
            this.AditextBox.TabIndex = 6;
            // 
            // tahdit
            // 
            this.tahdit.AutoSize = true;
            this.tahdit.Location = new System.Drawing.Point(3, 143);
            this.tahdit.Name = "tahdit";
            this.tahdit.Size = new System.Drawing.Size(108, 13);
            this.tahdit.TabIndex = 5;
            this.tahdit.Text = "TAHDİTLİ ALANLAR";
            this.tahdit.Click += new System.EventHandler(this.label6_Click);
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Location = new System.Drawing.Point(3, 116);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(78, 13);
            this.tc.TabIndex = 4;
            this.tc.Text = "TC KİMLİK NO";
            this.tc.Click += new System.EventHandler(this.tc_Click);
            // 
            // gorev
            // 
            this.gorev.AutoSize = true;
            this.gorev.Location = new System.Drawing.Point(3, 91);
            this.gorev.Name = "gorev";
            this.gorev.Size = new System.Drawing.Size(48, 13);
            this.gorev.TabIndex = 3;
            this.gorev.Text = "GÖREVİ";
            this.gorev.Click += new System.EventHandler(this.gorev_Click);
            // 
            // kurum
            // 
            this.kurum.AutoSize = true;
            this.kurum.Location = new System.Drawing.Point(3, 65);
            this.kurum.Name = "kurum";
            this.kurum.Size = new System.Drawing.Size(55, 13);
            this.kurum.TabIndex = 2;
            this.kurum.Text = "KURUMU";
            // 
            // soyadi
            // 
            this.soyadi.AutoSize = true;
            this.soyadi.Location = new System.Drawing.Point(3, 39);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(47, 13);
            this.soyadi.TabIndex = 1;
            this.soyadi.Text = "SOYADI";
            this.soyadi.Click += new System.EventHandler(this.label2_Click);
            // 
            // adi
            // 
            this.adi.AutoSize = true;
            this.adi.Location = new System.Drawing.Point(3, 16);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(25, 13);
            this.adi.TabIndex = 0;
            this.adi.Text = "ADI";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.asagi);
            this.panel1.Controls.Add(this.equal);
            this.panel1.Controls.Add(this.yukari);
            this.panel1.Controls.Add(this.buyuktur);
            this.panel1.Controls.Add(this.kucuktur);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.noktalama);
            this.panel1.Location = new System.Drawing.Point(152, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 59);
            this.panel1.TabIndex = 8;
            // 
            // asagi
            // 
            this.asagi.BackColor = System.Drawing.Color.Silver;
            this.asagi.Location = new System.Drawing.Point(143, 35);
            this.asagi.Name = "asagi";
            this.asagi.Size = new System.Drawing.Size(56, 24);
            this.asagi.TabIndex = 11;
            this.asagi.Text = "Aşağı";
            this.asagi.UseVisualStyleBackColor = false;
            this.asagi.MouseLeave += new System.EventHandler(this.asagi_MouseLeave);
            this.asagi.MouseHover += new System.EventHandler(this.asagi_MouseHover);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.equal.Location = new System.Drawing.Point(138, 2);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(18, 25);
            this.equal.TabIndex = 12;
            this.equal.Text = ":";
            // 
            // yukari
            // 
            this.yukari.BackColor = System.Drawing.Color.Silver;
            this.yukari.Location = new System.Drawing.Point(93, 35);
            this.yukari.Name = "yukari";
            this.yukari.Size = new System.Drawing.Size(54, 24);
            this.yukari.TabIndex = 10;
            this.yukari.Text = "Yukarı";
            this.yukari.UseVisualStyleBackColor = false;
            this.yukari.MouseLeave += new System.EventHandler(this.yukari_MouseLeave);
            this.yukari.MouseHover += new System.EventHandler(this.yukari_MouseHover);
            // 
            // buyuktur
            // 
            this.buyuktur.BackColor = System.Drawing.Color.Silver;
            this.buyuktur.Location = new System.Drawing.Point(160, 5);
            this.buyuktur.Name = "buyuktur";
            this.buyuktur.Size = new System.Drawing.Size(39, 24);
            this.buyuktur.TabIndex = 12;
            this.buyuktur.Text = ">";
            this.buyuktur.UseVisualStyleBackColor = false;
            this.buyuktur.Click += new System.EventHandler(this.buyuktur_Click);
            this.buyuktur.MouseLeave += new System.EventHandler(this.buyuktur_MouseLeave);
            this.buyuktur.MouseHover += new System.EventHandler(this.buyuktur_MouseHover);
            // 
            // kucuktur
            // 
            this.kucuktur.BackColor = System.Drawing.Color.Silver;
            this.kucuktur.Location = new System.Drawing.Point(93, 5);
            this.kucuktur.Name = "kucuktur";
            this.kucuktur.Size = new System.Drawing.Size(39, 24);
            this.kucuktur.TabIndex = 2;
            this.kucuktur.Text = "<";
            this.kucuktur.UseVisualStyleBackColor = false;
            this.kucuktur.MouseLeave += new System.EventHandler(this.kucuktur_MouseLeave);
            this.kucuktur.MouseHover += new System.EventHandler(this.kucuktur_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kurumu";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // noktalama
            // 
            this.noktalama.AutoSize = true;
            this.noktalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noktalama.ForeColor = System.Drawing.Color.White;
            this.noktalama.Location = new System.Drawing.Point(2, 5);
            this.noktalama.Name = "noktalama";
            this.noktalama.Size = new System.Drawing.Size(85, 20);
            this.noktalama.TabIndex = 0;
            this.noktalama.Text = "Noktalama";
            this.noktalama.Click += new System.EventHandler(this.noktalama_Click);
            // 
            // guncelle
            // 
            this.guncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guncelle.BackColor = System.Drawing.Color.Silver;
            this.guncelle.ForeColor = System.Drawing.Color.Black;
            this.guncelle.Image = ((System.Drawing.Image)(resources.GetObject("guncelle.Image")));
            this.guncelle.Location = new System.Drawing.Point(357, 211);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(75, 59);
            this.guncelle.TabIndex = 10;
            this.guncelle.Text = "Güncelle";
            this.guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            this.guncelle.MouseLeave += new System.EventHandler(this.guncelle_MouseLeave);
            this.guncelle.MouseHover += new System.EventHandler(this.guncelle_MouseHover);
            // 
            // arkaSayfaBtn
            // 
            this.arkaSayfaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arkaSayfaBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.arkaSayfaBtn.Image = ((System.Drawing.Image)(resources.GetObject("arkaSayfaBtn.Image")));
            this.arkaSayfaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arkaSayfaBtn.Location = new System.Drawing.Point(11, 602);
            this.arkaSayfaBtn.Name = "arkaSayfaBtn";
            this.arkaSayfaBtn.Size = new System.Drawing.Size(135, 30);
            this.arkaSayfaBtn.TabIndex = 11;
            this.arkaSayfaBtn.Text = "Arka Sayfa";
            this.arkaSayfaBtn.UseVisualStyleBackColor = false;
            this.arkaSayfaBtn.Click += new System.EventHandler(this.arkaSayfaBtn_Click);
            this.arkaSayfaBtn.MouseLeave += new System.EventHandler(this.arkaSayfaBtn_MouseLeave);
            this.arkaSayfaBtn.MouseHover += new System.EventHandler(this.arkaSayfaBtn_MouseHover);
            // 
            // anaSayfaBtn
            // 
            this.anaSayfaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.anaSayfaBtn.BackColor = System.Drawing.Color.White;
            this.anaSayfaBtn.Image = ((System.Drawing.Image)(resources.GetObject("anaSayfaBtn.Image")));
            this.anaSayfaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaSayfaBtn.Location = new System.Drawing.Point(149, 602);
            this.anaSayfaBtn.Name = "anaSayfaBtn";
            this.anaSayfaBtn.Size = new System.Drawing.Size(135, 30);
            this.anaSayfaBtn.TabIndex = 12;
            this.anaSayfaBtn.Text = "Ana Sayfa";
            this.anaSayfaBtn.UseVisualStyleBackColor = false;
            this.anaSayfaBtn.Click += new System.EventHandler(this.anaSayfaBtn_Click);
            this.anaSayfaBtn.MouseLeave += new System.EventHandler(this.anaSayfaBtn_MouseLeave);
            this.anaSayfaBtn.MouseHover += new System.EventHandler(this.anaSayfaBtn_MouseHover);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(17, 276);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(415, 304);
            this.axAcroPDF1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(305, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // KisiGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(462, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.anaSayfaBtn);
            this.Controls.Add(this.arkaSayfaBtn);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.limanlar);
            this.Controls.Add(this.FotoEkleButton);
            this.Controls.Add(this.setImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KisiGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisForm";
            this.Load += new System.EventHandler(this.KisiGirisForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KisiGirisForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KisiGirisForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KisiGirisForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.setImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.PictureBox setImage;
        private System.Windows.Forms.Button FotoEkleButton;
        private System.Windows.Forms.ComboBox limanlar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tahdit;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.Label gorev;
        private System.Windows.Forms.Label kurum;
        private System.Windows.Forms.Label soyadi;
        private System.Windows.Forms.Label adi;
        private System.Windows.Forms.TextBox GorevtextBox;
        private System.Windows.Forms.TextBox KurumtextBox;
        private System.Windows.Forms.TextBox SoyaditextBox;
        private System.Windows.Forms.TextBox AditextBox;
        private System.Windows.Forms.TextBox TctextBox;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox FontSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noktalama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Button buyuktur;
        private System.Windows.Forms.Button kucuktur;
        private System.Windows.Forms.Button yukari;
        private System.Windows.Forms.Button asagi;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button arkaSayfaBtn;
        private System.Windows.Forms.Button anaSayfaBtn;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button button1;
    }
}