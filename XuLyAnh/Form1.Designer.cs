namespace XuLyAnh
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBrowse1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnBrowse2 = new System.Windows.Forms.Button();
            this.lblBitString1 = new System.Windows.Forms.Label();
            this.lblBinNumber1 = new System.Windows.Forms.Label();
            this.lblBinNumber2 = new System.Windows.Forms.Label();
            this.lblBitString2 = new System.Windows.Forms.Label();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBrowse1
            // 
            this.BtnBrowse1.Location = new System.Drawing.Point(173, 447);
            this.BtnBrowse1.Name = "BtnBrowse1";
            this.BtnBrowse1.Size = new System.Drawing.Size(80, 40);
            this.BtnBrowse1.TabIndex = 1;
            this.BtnBrowse1.Text = "Browse";
            this.BtnBrowse1.UseVisualStyleBackColor = true;
            this.BtnBrowse1.Click += new System.EventHandler(this.BtnBrowse1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(766, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BtnBrowse2
            // 
            this.BtnBrowse2.Location = new System.Drawing.Point(926, 447);
            this.BtnBrowse2.Name = "BtnBrowse2";
            this.BtnBrowse2.Size = new System.Drawing.Size(80, 40);
            this.BtnBrowse2.TabIndex = 3;
            this.BtnBrowse2.Text = "Browse";
            this.BtnBrowse2.UseVisualStyleBackColor = true;
            this.BtnBrowse2.Click += new System.EventHandler(this.BtnBrowse2_Click);
            // 
            // lblBitString1
            // 
            this.lblBitString1.AutoSize = true;
            this.lblBitString1.Location = new System.Drawing.Point(12, 545);
            this.lblBitString1.Name = "lblBitString1";
            this.lblBitString1.Size = new System.Drawing.Size(0, 20);
            this.lblBitString1.TabIndex = 6;
            // 
            // lblBinNumber1
            // 
            this.lblBinNumber1.AutoSize = true;
            this.lblBinNumber1.Location = new System.Drawing.Point(12, 501);
            this.lblBinNumber1.Name = "lblBinNumber1";
            this.lblBinNumber1.Size = new System.Drawing.Size(90, 20);
            this.lblBinNumber1.TabIndex = 7;
            this.lblBinNumber1.Text = "Chuỗi Bin 1";
            // 
            // lblBinNumber2
            // 
            this.lblBinNumber2.AutoSize = true;
            this.lblBinNumber2.Location = new System.Drawing.Point(762, 501);
            this.lblBinNumber2.Name = "lblBinNumber2";
            this.lblBinNumber2.Size = new System.Drawing.Size(90, 20);
            this.lblBinNumber2.TabIndex = 8;
            this.lblBinNumber2.Text = "Chuỗi Bin 2";
            // 
            // lblBitString2
            // 
            this.lblBitString2.AutoSize = true;
            this.lblBitString2.Location = new System.Drawing.Point(766, 545);
            this.lblBitString2.Name = "lblBitString2";
            this.lblBitString2.Size = new System.Drawing.Size(0, 20);
            this.lblBitString2.TabIndex = 9;
            // 
            // BtnCompare
            // 
            this.BtnCompare.Location = new System.Drawing.Point(548, 205);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(90, 40);
            this.BtnCompare.TabIndex = 10;
            this.BtnCompare.Text = "Compare";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(16, 545);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(397, 252);
            this.txt1.TabIndex = 11;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(766, 542);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(397, 252);
            this.txt2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.BtnCompare);
            this.Controls.Add(this.lblBitString2);
            this.Controls.Add(this.lblBinNumber2);
            this.Controls.Add(this.lblBinNumber1);
            this.Controls.Add(this.lblBitString1);
            this.Controls.Add(this.BtnBrowse2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnBrowse1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBrowse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnBrowse2;
        private System.Windows.Forms.Label lblBitString1;
        private System.Windows.Forms.Label lblBinNumber1;
        private System.Windows.Forms.Label lblBinNumber2;
        private System.Windows.Forms.Label lblBitString2;
        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}

