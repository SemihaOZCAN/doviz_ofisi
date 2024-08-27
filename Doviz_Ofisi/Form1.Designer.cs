namespace Doviz_Ofisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDAlis = new System.Windows.Forms.Label();
            this.lblDSatis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblESatis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEAlis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDalis = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonIslem1 = new System.Windows.Forms.Button();
            this.textBoxKalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxKur = new System.Windows.Forms.TextBox();
            this.buttonDsatis = new System.Windows.Forms.Button();
            this.buttonEalis = new System.Windows.Forms.Button();
            this.buttonEsatis = new System.Windows.Forms.Button();
            this.buttonIslem2 = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // lblDAlis
            // 
            this.lblDAlis.AutoSize = true;
            this.lblDAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblDAlis.ForeColor = System.Drawing.Color.White;
            this.lblDAlis.Location = new System.Drawing.Point(177, 30);
            this.lblDAlis.Name = "lblDAlis";
            this.lblDAlis.Size = new System.Drawing.Size(22, 24);
            this.lblDAlis.TabIndex = 1;
            this.lblDAlis.Text = "0";
            // 
            // lblDSatis
            // 
            this.lblDSatis.AutoSize = true;
            this.lblDSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblDSatis.ForeColor = System.Drawing.Color.White;
            this.lblDSatis.Location = new System.Drawing.Point(177, 67);
            this.lblDSatis.Name = "lblDSatis";
            this.lblDSatis.Size = new System.Drawing.Size(22, 24);
            this.lblDSatis.TabIndex = 3;
            this.lblDSatis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dolar Satış:";
            // 
            // lblESatis
            // 
            this.lblESatis.AutoSize = true;
            this.lblESatis.BackColor = System.Drawing.Color.Transparent;
            this.lblESatis.ForeColor = System.Drawing.Color.White;
            this.lblESatis.Location = new System.Drawing.Point(177, 167);
            this.lblESatis.Name = "lblESatis";
            this.lblESatis.Size = new System.Drawing.Size(22, 24);
            this.lblESatis.TabIndex = 7;
            this.lblESatis.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Euro Satış:";
            // 
            // lblEAlis
            // 
            this.lblEAlis.AutoSize = true;
            this.lblEAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblEAlis.ForeColor = System.Drawing.Color.White;
            this.lblEAlis.Location = new System.Drawing.Point(177, 127);
            this.lblEAlis.Name = "lblEAlis";
            this.lblEAlis.Size = new System.Drawing.Size(22, 24);
            this.lblEAlis.TabIndex = 5;
            this.lblEAlis.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(82, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Euro Alış:";
            // 
            // buttonDalis
            // 
            this.buttonDalis.Location = new System.Drawing.Point(255, 30);
            this.buttonDalis.Name = "buttonDalis";
            this.buttonDalis.Size = new System.Drawing.Size(35, 30);
            this.buttonDalis.TabIndex = 8;
            this.buttonDalis.Text = "...";
            this.buttonDalis.UseVisualStyleBackColor = true;
            this.buttonDalis.Click += new System.EventHandler(this.buttonDalis_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kur:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonIslem2);
            this.groupBox1.Controls.Add(this.buttonIslem1);
            this.groupBox1.Controls.Add(this.textBoxKalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(330, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 266);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // buttonIslem1
            // 
            this.buttonIslem1.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonIslem1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIslem1.Location = new System.Drawing.Point(6, 218);
            this.buttonIslem1.Name = "buttonIslem1";
            this.buttonIslem1.Size = new System.Drawing.Size(187, 42);
            this.buttonIslem1.TabIndex = 17;
            this.buttonIslem1.Text = " Tutar Hesapla";
            this.buttonIslem1.UseVisualStyleBackColor = false;
            this.buttonIslem1.Click += new System.EventHandler(this.buttonIslem1_Click);
            // 
            // textBoxKalan
            // 
            this.textBoxKalan.Location = new System.Drawing.Point(79, 181);
            this.textBoxKalan.Name = "textBoxKalan";
            this.textBoxKalan.Size = new System.Drawing.Size(284, 30);
            this.textBoxKalan.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kalan:";
            // 
            // textBoxTutar
            // 
            this.textBoxTutar.Location = new System.Drawing.Point(79, 135);
            this.textBoxTutar.Name = "textBoxTutar";
            this.textBoxTutar.Size = new System.Drawing.Size(284, 30);
            this.textBoxTutar.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tutar:";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.Location = new System.Drawing.Point(79, 87);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(284, 30);
            this.textBoxMiktar.TabIndex = 12;
            this.textBoxMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiktar_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Miktar:";
            // 
            // textBoxKur
            // 
            this.textBoxKur.Location = new System.Drawing.Point(79, 39);
            this.textBoxKur.Name = "textBoxKur";
            this.textBoxKur.Size = new System.Drawing.Size(284, 30);
            this.textBoxKur.TabIndex = 10;
            this.textBoxKur.TextChanged += new System.EventHandler(this.textBoxKur_TextChanged);
            // 
            // buttonDsatis
            // 
            this.buttonDsatis.Location = new System.Drawing.Point(255, 67);
            this.buttonDsatis.Name = "buttonDsatis";
            this.buttonDsatis.Size = new System.Drawing.Size(35, 30);
            this.buttonDsatis.TabIndex = 11;
            this.buttonDsatis.Text = "...";
            this.buttonDsatis.UseVisualStyleBackColor = true;
            this.buttonDsatis.Click += new System.EventHandler(this.buttonDsatis_Click);
            // 
            // buttonEalis
            // 
            this.buttonEalis.Location = new System.Drawing.Point(255, 127);
            this.buttonEalis.Name = "buttonEalis";
            this.buttonEalis.Size = new System.Drawing.Size(35, 30);
            this.buttonEalis.TabIndex = 12;
            this.buttonEalis.Text = "...";
            this.buttonEalis.UseVisualStyleBackColor = true;
            this.buttonEalis.Click += new System.EventHandler(this.buttonEalis_Click);
            // 
            // buttonEsatis
            // 
            this.buttonEsatis.Location = new System.Drawing.Point(255, 167);
            this.buttonEsatis.Name = "buttonEsatis";
            this.buttonEsatis.Size = new System.Drawing.Size(35, 30);
            this.buttonEsatis.TabIndex = 13;
            this.buttonEsatis.Text = "...";
            this.buttonEsatis.UseVisualStyleBackColor = true;
            this.buttonEsatis.Click += new System.EventHandler(this.buttonEsatis_Click);
            // 
            // buttonIslem2
            // 
            this.buttonIslem2.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonIslem2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIslem2.Location = new System.Drawing.Point(197, 217);
            this.buttonIslem2.Name = "buttonIslem2";
            this.buttonIslem2.Size = new System.Drawing.Size(219, 42);
            this.buttonIslem2.TabIndex = 18;
            this.buttonIslem2.Text = "Bozdurma Hesapla";
            this.buttonIslem2.UseVisualStyleBackColor = false;
            this.buttonIslem2.Click += new System.EventHandler(this.buttonIslem2_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.ForeColor = System.Drawing.Color.Black;
            this.lblTarih.Location = new System.Drawing.Point(405, 167);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(64, 24);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1045, 536);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.buttonEsatis);
            this.Controls.Add(this.buttonEalis);
            this.Controls.Add(this.buttonDsatis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDalis);
            this.Controls.Add(this.lblESatis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEAlis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDSatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDAlis);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DÖVİZ BÜROSU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDAlis;
        private System.Windows.Forms.Label lblDSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblESatis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEAlis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDalis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxKur;
        private System.Windows.Forms.Button buttonDsatis;
        private System.Windows.Forms.Button buttonEalis;
        private System.Windows.Forms.Button buttonEsatis;
        private System.Windows.Forms.Button buttonIslem1;
        private System.Windows.Forms.TextBox textBoxKalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonIslem2;
        private System.Windows.Forms.Label lblTarih;
    }
}

