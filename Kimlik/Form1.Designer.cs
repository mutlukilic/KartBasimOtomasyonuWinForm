namespace Kimlik
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AracGiris = new System.Windows.Forms.Button();
            this.KisiGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(54, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "KART BASIM PROGRAMI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AracGiris
            // 
            this.AracGiris.BackColor = System.Drawing.Color.White;
            this.AracGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AracGiris.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.AracGiris.Image = ((System.Drawing.Image)(resources.GetObject("AracGiris.Image")));
            this.AracGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AracGiris.Location = new System.Drawing.Point(88, 393);
            this.AracGiris.Name = "AracGiris";
            this.AracGiris.Size = new System.Drawing.Size(287, 103);
            this.AracGiris.TabIndex = 5;
            this.AracGiris.Text = "     Araç Giriş Kartı";
            this.AracGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AracGiris.UseVisualStyleBackColor = false;
            this.AracGiris.Click += new System.EventHandler(this.AracGiris_Click);
            // 
            // KisiGiris
            // 
            this.KisiGiris.BackColor = System.Drawing.Color.White;
            this.KisiGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KisiGiris.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KisiGiris.ForeColor = System.Drawing.Color.Black;
            this.KisiGiris.Image = ((System.Drawing.Image)(resources.GetObject("KisiGiris.Image")));
            this.KisiGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KisiGiris.Location = new System.Drawing.Point(88, 284);
            this.KisiGiris.Name = "KisiGiris";
            this.KisiGiris.Size = new System.Drawing.Size(287, 103);
            this.KisiGiris.TabIndex = 4;
            this.KisiGiris.Text = "     Kişi Giriş Kartı";
            this.KisiGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KisiGiris.UseVisualStyleBackColor = false;
            this.KisiGiris.Click += new System.EventHandler(this.KisiGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(469, 640);
            this.Controls.Add(this.AracGiris);
            this.Controls.Add(this.KisiGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AracGiris;
        private System.Windows.Forms.Button KisiGiris;
    }
}

