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
            this.BtnSetPictureBox1 = new System.Windows.Forms.Button();
            this.Lbl1 = new System.Windows.Forms.Label();
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
            this.pictureBox2.Location = new System.Drawing.Point(566, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BtnBrowse2
            // 
            this.BtnBrowse2.Location = new System.Drawing.Point(726, 447);
            this.BtnBrowse2.Name = "BtnBrowse2";
            this.BtnBrowse2.Size = new System.Drawing.Size(80, 40);
            this.BtnBrowse2.TabIndex = 3;
            this.BtnBrowse2.Text = "Browse";
            this.BtnBrowse2.UseVisualStyleBackColor = true;
            this.BtnBrowse2.Click += new System.EventHandler(this.BtnBrowse2_Click);
            // 
            // BtnSetPictureBox1
            // 
            this.BtnSetPictureBox1.Location = new System.Drawing.Point(173, 584);
            this.BtnSetPictureBox1.Name = "BtnSetPictureBox1";
            this.BtnSetPictureBox1.Size = new System.Drawing.Size(80, 40);
            this.BtnSetPictureBox1.TabIndex = 4;
            this.BtnSetPictureBox1.Text = "Browse";
            this.BtnSetPictureBox1.UseVisualStyleBackColor = true;
            this.BtnSetPictureBox1.Click += new System.EventHandler(this.BtnSetPictureBox1_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(173, 680);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(51, 20);
            this.Lbl1.TabIndex = 6;
            this.Lbl1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.BtnSetPictureBox1);
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
        private System.Windows.Forms.Button BtnSetPictureBox1;
        private System.Windows.Forms.Label Lbl1;
    }
}

