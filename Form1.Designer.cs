namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.serviceController2 = new System.ServiceProcess.ServiceController();
            this.flatStift1 = new Stift.FlatStift();
            this.customButtonClearWindows = new ButtonSilvio.customButton();
            this.customButtonChangeColor = new ButtonSilvio.customButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatStift1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 367);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(648, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 43);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(103, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 24);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 24);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox3.Location = new System.Drawing.Point(74, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 24);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumBlue;
            this.pictureBox2.Location = new System.Drawing.Point(45, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flatStift1
            // 
            this.flatStift1.BackColor = System.Drawing.Color.White;
            this.flatStift1.ForeColor = System.Drawing.Color.Blue;
            this.flatStift1.Location = new System.Drawing.Point(12, 21);
            this.flatStift1.Name = "flatStift1";
            this.flatStift1.Size = new System.Drawing.Size(28, 33);
            this.flatStift1.TabIndex = 2;
            this.flatStift1.TabStop = false;
            this.flatStift1.Click += new System.EventHandler(this.flatStift1_Click);
            // 
            // customButtonClearWindows
            // 
            this.customButtonClearWindows.BackColor = System.Drawing.Color.DodgerBlue;
            this.customButtonClearWindows.ForeColor = System.Drawing.Color.White;
            this.customButtonClearWindows.Location = new System.Drawing.Point(286, 9);
            this.customButtonClearWindows.Name = "customButtonClearWindows";
            this.customButtonClearWindows.Size = new System.Drawing.Size(175, 44);
            this.customButtonClearWindows.TabIndex = 3;
            this.customButtonClearWindows.Text = "CLEAR WINDOW";
            this.customButtonClearWindows.UseVisualStyleBackColor = false;
            this.customButtonClearWindows.Click += new System.EventHandler(this.customButtonClearWindows_Click);
            // 
            // customButtonChangeColor
            // 
            this.customButtonChangeColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.customButtonChangeColor.ForeColor = System.Drawing.Color.White;
            this.customButtonChangeColor.Location = new System.Drawing.Point(467, 9);
            this.customButtonChangeColor.Name = "customButtonChangeColor";
            this.customButtonChangeColor.Size = new System.Drawing.Size(175, 44);
            this.customButtonChangeColor.TabIndex = 4;
            this.customButtonChangeColor.Text = "CHANGE COLOR";
            this.customButtonChangeColor.UseVisualStyleBackColor = false;
            this.customButtonChangeColor.Click += new System.EventHandler(this.customButtonChangeColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.customButtonChangeColor);
            this.Controls.Add(this.customButtonClearWindows);
            this.Controls.Add(this.flatStift1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatStift1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.ServiceProcess.ServiceController serviceController2;
        private Stift.FlatStift flatStift1;
        private ButtonSilvio.customButton customButtonClearWindows;
        private ButtonSilvio.customButton customButtonChangeColor;
    }
}

