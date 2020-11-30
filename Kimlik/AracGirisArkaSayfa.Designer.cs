namespace Kimlik
{
    partial class AracGirisArkaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracGirisArkaSayfa));
            this.button1 = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.SeriNotextBox = new System.Windows.Forms.TextBox();
            this.SeriNoID = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.anaSayfaBtn = new System.Windows.Forms.Button();
            this.arkaSayfaBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(313, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(4, 219);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(447, 382);
            this.axAcroPDF1.TabIndex = 37;
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.White;
            this.GuncelleBtn.Location = new System.Drawing.Point(315, 185);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(106, 23);
            this.GuncelleBtn.TabIndex = 36;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // SeriNotextBox
            // 
            this.SeriNotextBox.Location = new System.Drawing.Point(113, 185);
            this.SeriNotextBox.Name = "SeriNotextBox";
            this.SeriNotextBox.Size = new System.Drawing.Size(196, 20);
            this.SeriNotextBox.TabIndex = 34;
            // 
            // SeriNoID
            // 
            this.SeriNoID.AutoSize = true;
            this.SeriNoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SeriNoID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SeriNoID.Location = new System.Drawing.Point(179, 158);
            this.SeriNoID.Name = "SeriNoID";
            this.SeriNoID.Size = new System.Drawing.Size(78, 24);
            this.SeriNoID.TabIndex = 32;
            this.SeriNoID.Text = "Seri No:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(462, 154);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // anaSayfaBtn
            // 
            this.anaSayfaBtn.BackColor = System.Drawing.Color.White;
            this.anaSayfaBtn.Image = ((System.Drawing.Image)(resources.GetObject("anaSayfaBtn.Image")));
            this.anaSayfaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaSayfaBtn.Location = new System.Drawing.Point(140, 531);
            this.anaSayfaBtn.Name = "anaSayfaBtn";
            this.anaSayfaBtn.Size = new System.Drawing.Size(135, 30);
            this.anaSayfaBtn.TabIndex = 30;
            this.anaSayfaBtn.Text = "Ana Sayfa";
            this.anaSayfaBtn.UseVisualStyleBackColor = false;
            // 
            // arkaSayfaBtn
            // 
            this.arkaSayfaBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.arkaSayfaBtn.Image = ((System.Drawing.Image)(resources.GetObject("arkaSayfaBtn.Image")));
            this.arkaSayfaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arkaSayfaBtn.Location = new System.Drawing.Point(2, 531);
            this.arkaSayfaBtn.Name = "arkaSayfaBtn";
            this.arkaSayfaBtn.Size = new System.Drawing.Size(135, 30);
            this.arkaSayfaBtn.TabIndex = 29;
            this.arkaSayfaBtn.Text = "Arka Sayfa";
            this.arkaSayfaBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(156, 607);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 30);
            this.button2.TabIndex = 40;
            this.button2.Text = "Ana Sayfa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(18, 607);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 30);
            this.button3.TabIndex = 39;
            this.button3.Text = "Arka Sayfa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // AracGirisArkaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(469, 640);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.SeriNotextBox);
            this.Controls.Add(this.SeriNoID);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.anaSayfaBtn);
            this.Controls.Add(this.arkaSayfaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AracGirisArkaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracGirisArkaSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.TextBox SeriNotextBox;
        private System.Windows.Forms.Label SeriNoID;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button anaSayfaBtn;
        private System.Windows.Forms.Button arkaSayfaBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}