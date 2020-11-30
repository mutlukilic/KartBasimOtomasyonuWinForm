namespace Kimlik
{
    partial class KisiGirisArkaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiGirisArkaSayfa));
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.anaSayfaBtn = new System.Windows.Forms.Button();
            this.arkaSayfaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SeriNoID = new System.Windows.Forms.Label();
            this.AracID = new System.Windows.Forms.Label();
            this.SeriNotextBox = new System.Windows.Forms.TextBox();
            this.AracPlakasıTextBox = new System.Windows.Forms.TextBox();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(406, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(28, 25);
            this.minimize.TabIndex = 4;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // anaSayfaBtn
            // 
            this.anaSayfaBtn.BackColor = System.Drawing.Color.White;
            this.anaSayfaBtn.Image = ((System.Drawing.Image)(resources.GetObject("anaSayfaBtn.Image")));
            this.anaSayfaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaSayfaBtn.Location = new System.Drawing.Point(152, 602);
            this.anaSayfaBtn.Name = "anaSayfaBtn";
            this.anaSayfaBtn.Size = new System.Drawing.Size(135, 30);
            this.anaSayfaBtn.TabIndex = 14;
            this.anaSayfaBtn.Text = "Ana Sayfa";
            this.anaSayfaBtn.UseVisualStyleBackColor = false;
            this.anaSayfaBtn.Click += new System.EventHandler(this.anaSayfaBtn_Click);
            // 
            // arkaSayfaBtn
            // 
            this.arkaSayfaBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.arkaSayfaBtn.Image = ((System.Drawing.Image)(resources.GetObject("arkaSayfaBtn.Image")));
            this.arkaSayfaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arkaSayfaBtn.Location = new System.Drawing.Point(14, 602);
            this.arkaSayfaBtn.Name = "arkaSayfaBtn";
            this.arkaSayfaBtn.Size = new System.Drawing.Size(135, 30);
            this.arkaSayfaBtn.TabIndex = 13;
            this.arkaSayfaBtn.Text = "Arka Sayfa";
            this.arkaSayfaBtn.UseVisualStyleBackColor = false;
            this.arkaSayfaBtn.Click += new System.EventHandler(this.arkaSayfaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(198, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "T.C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(150, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "HATAY VALİLİĞİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(68, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "LİMANLAR MÜLKİ İDARE AMİRLİĞİ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(161, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "GİRİŞ KARTI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(-3, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(462, 154);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // SeriNoID
            // 
            this.SeriNoID.AutoSize = true;
            this.SeriNoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SeriNoID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SeriNoID.Location = new System.Drawing.Point(12, 225);
            this.SeriNoID.Name = "SeriNoID";
            this.SeriNoID.Size = new System.Drawing.Size(78, 24);
            this.SeriNoID.TabIndex = 20;
            this.SeriNoID.Text = "Seri No:";
            // 
            // AracID
            // 
            this.AracID.AutoSize = true;
            this.AracID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AracID.Location = new System.Drawing.Point(263, 225);
            this.AracID.Name = "AracID";
            this.AracID.Size = new System.Drawing.Size(117, 24);
            this.AracID.TabIndex = 21;
            this.AracID.Text = "Araç Plakası:";
            // 
            // SeriNotextBox
            // 
            this.SeriNotextBox.Location = new System.Drawing.Point(16, 246);
            this.SeriNotextBox.Name = "SeriNotextBox";
            this.SeriNotextBox.Size = new System.Drawing.Size(196, 20);
            this.SeriNotextBox.TabIndex = 22;
            this.SeriNotextBox.TextChanged += new System.EventHandler(this.SeriNotextBox_TextChanged);
            // 
            // AracPlakasıTextBox
            // 
            this.AracPlakasıTextBox.Location = new System.Drawing.Point(267, 246);
            this.AracPlakasıTextBox.Name = "AracPlakasıTextBox";
            this.AracPlakasıTextBox.Size = new System.Drawing.Size(196, 20);
            this.AracPlakasıTextBox.TabIndex = 23;
            this.AracPlakasıTextBox.TextChanged += new System.EventHandler(this.AracPlakasıTextBox_TextChanged);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.White;
            this.GuncelleBtn.Location = new System.Drawing.Point(357, 266);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(106, 23);
            this.GuncelleBtn.TabIndex = 24;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            this.GuncelleBtn.MouseLeave += new System.EventHandler(this.GuncelleBtn_MouseLeave);
            this.GuncelleBtn.MouseHover += new System.EventHandler(this.GuncelleBtn_MouseHover);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(16, 290);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(415, 304);
            this.axAcroPDF1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(299, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // KisiGirisArkaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(469, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.AracPlakasıTextBox);
            this.Controls.Add(this.SeriNotextBox);
            this.Controls.Add(this.AracID);
            this.Controls.Add(this.SeriNoID);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anaSayfaBtn);
            this.Controls.Add(this.arkaSayfaBtn);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KisiGirisArkaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KisiGirisArkaSayfa";
            this.Load += new System.EventHandler(this.KisiGirisArkaSayfa_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KisiGirisArkaSayfa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KisiGirisArkaSayfa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KisiGirisArkaSayfa_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button anaSayfaBtn;
        private System.Windows.Forms.Button arkaSayfaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label SeriNoID;
        private System.Windows.Forms.Label AracID;
        private System.Windows.Forms.TextBox SeriNotextBox;
        private System.Windows.Forms.TextBox AracPlakasıTextBox;
        private System.Windows.Forms.Button GuncelleBtn;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button button1;
    }
}