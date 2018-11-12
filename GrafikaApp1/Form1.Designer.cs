namespace GrafikaApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRysuj = new System.Windows.Forms.Button();
            this.tX = new System.Windows.Forms.TextBox();
            this.tY = new System.Windows.Forms.TextBox();
            this.tXP = new System.Windows.Forms.TextBox();
            this.tYP = new System.Windows.Forms.TextBox();
            this.tSize = new System.Windows.Forms.TextBox();
            this.BtnLine = new System.Windows.Forms.Button();
            this.tWidth = new System.Windows.Forms.TextBox();
            this.tHeight = new System.Windows.Forms.TextBox();
            this.tRadius = new System.Windows.Forms.TextBox();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRGB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRysuj
            // 
            this.BtnRysuj.Location = new System.Drawing.Point(13, 13);
            this.BtnRysuj.Name = "BtnRysuj";
            this.BtnRysuj.Size = new System.Drawing.Size(162, 23);
            this.BtnRysuj.TabIndex = 0;
            this.BtnRysuj.Text = "RYSUJ";
            this.BtnRysuj.UseVisualStyleBackColor = true;
            this.BtnRysuj.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // tX
            // 
            this.tX.Location = new System.Drawing.Point(80, 46);
            this.tX.Name = "tX";
            this.tX.Size = new System.Drawing.Size(36, 20);
            this.tX.TabIndex = 2;
            this.tX.Text = "0";
            // 
            // tY
            // 
            this.tY.Location = new System.Drawing.Point(119, 46);
            this.tY.Name = "tY";
            this.tY.Size = new System.Drawing.Size(36, 20);
            this.tY.TabIndex = 3;
            this.tY.Text = "0";
            // 
            // tXP
            // 
            this.tXP.Location = new System.Drawing.Point(81, 72);
            this.tXP.Name = "tXP";
            this.tXP.Size = new System.Drawing.Size(36, 20);
            this.tXP.TabIndex = 4;
            this.tXP.Text = "100";
            // 
            // tYP
            // 
            this.tYP.Location = new System.Drawing.Point(120, 72);
            this.tYP.Name = "tYP";
            this.tYP.Size = new System.Drawing.Size(36, 20);
            this.tYP.TabIndex = 5;
            this.tYP.Text = "100";
            // 
            // tSize
            // 
            this.tSize.Location = new System.Drawing.Point(81, 98);
            this.tSize.Name = "tSize";
            this.tSize.Size = new System.Drawing.Size(36, 20);
            this.tSize.TabIndex = 6;
            this.tSize.Text = "3";
            // 
            // BtnLine
            // 
            this.BtnLine.Location = new System.Drawing.Point(13, 196);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(50, 23);
            this.BtnLine.TabIndex = 7;
            this.BtnLine.Text = "Linia";
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // tWidth
            // 
            this.tWidth.Location = new System.Drawing.Point(80, 124);
            this.tWidth.Name = "tWidth";
            this.tWidth.Size = new System.Drawing.Size(36, 20);
            this.tWidth.TabIndex = 8;
            this.tWidth.Text = "200";
            // 
            // tHeight
            // 
            this.tHeight.Location = new System.Drawing.Point(122, 124);
            this.tHeight.Name = "tHeight";
            this.tHeight.Size = new System.Drawing.Size(36, 20);
            this.tHeight.TabIndex = 9;
            this.tHeight.Text = "200";
            // 
            // tRadius
            // 
            this.tRadius.Location = new System.Drawing.Point(80, 152);
            this.tRadius.Name = "tRadius";
            this.tRadius.Size = new System.Drawing.Size(36, 20);
            this.tRadius.TabIndex = 10;
            this.tRadius.Text = "300";
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRectangle.Location = new System.Drawing.Point(69, 196);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(50, 23);
            this.BtnRectangle.TabIndex = 11;
            this.BtnRectangle.Text = "Prostokąt";
            this.BtnRectangle.UseVisualStyleBackColor = true;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.Location = new System.Drawing.Point(125, 196);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(50, 23);
            this.BtnCircle.TabIndex = 12;
            this.BtnCircle.Text = "Okręg";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "X0, Y0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "X\', Y\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rozmiar";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "szerokość, wysokość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "promień";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(13, 225);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(162, 23);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "Wyczyść";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRGB
            // 
            this.BtnRGB.Location = new System.Drawing.Point(13, 254);
            this.BtnRGB.Name = "BtnRGB";
            this.BtnRGB.Size = new System.Drawing.Size(50, 23);
            this.BtnRGB.TabIndex = 19;
            this.BtnRGB.Text = "Kolor RGB";
            this.BtnRGB.UseVisualStyleBackColor = true;
            this.BtnRGB.Click += new System.EventHandler(this.BtnRGB_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(94, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 20;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(181, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 538);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnRGB);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCircle);
            this.Controls.Add(this.BtnRectangle);
            this.Controls.Add(this.tRadius);
            this.Controls.Add(this.tHeight);
            this.Controls.Add(this.tWidth);
            this.Controls.Add(this.BtnLine);
            this.Controls.Add(this.tSize);
            this.Controls.Add(this.tYP);
            this.Controls.Add(this.tXP);
            this.Controls.Add(this.tY);
            this.Controls.Add(this.tX);
            this.Controls.Add(this.BtnRysuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRysuj;
        private System.Windows.Forms.TextBox tX;
        private System.Windows.Forms.TextBox tY;
        private System.Windows.Forms.TextBox tXP;
        private System.Windows.Forms.TextBox tYP;
        private System.Windows.Forms.TextBox tSize;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.TextBox tWidth;
        private System.Windows.Forms.TextBox tHeight;
        private System.Windows.Forms.TextBox tRadius;
        private System.Windows.Forms.Button BtnRectangle;
        private System.Windows.Forms.Button BtnCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnRGB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

