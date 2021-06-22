namespace KinectV2Sesh
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
            this.txtMidSpineX = new System.Windows.Forms.TextBox();
            this.txtMidSpineY = new System.Windows.Forms.TextBox();
            this.txtMidSpineZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbDisX = new System.Windows.Forms.TextBox();
            this.tbDisY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMidSpineX
            // 
            this.txtMidSpineX.Location = new System.Drawing.Point(894, 8);
            this.txtMidSpineX.Name = "txtMidSpineX";
            this.txtMidSpineX.Size = new System.Drawing.Size(100, 20);
            this.txtMidSpineX.TabIndex = 0;
            this.txtMidSpineX.Visible = false;
            // 
            // txtMidSpineY
            // 
            this.txtMidSpineY.Location = new System.Drawing.Point(894, 34);
            this.txtMidSpineY.Name = "txtMidSpineY";
            this.txtMidSpineY.Size = new System.Drawing.Size(100, 20);
            this.txtMidSpineY.TabIndex = 1;
            this.txtMidSpineY.Visible = false;
            // 
            // txtMidSpineZ
            // 
            this.txtMidSpineZ.Location = new System.Drawing.Point(894, 60);
            this.txtMidSpineZ.Name = "txtMidSpineZ";
            this.txtMidSpineZ.Size = new System.Drawing.Size(100, 20);
            this.txtMidSpineZ.TabIndex = 2;
            this.txtMidSpineZ.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coord X";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(843, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coord Y";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coord Z";
            this.label3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, -81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 1200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tbDisX
            // 
            this.tbDisX.Location = new System.Drawing.Point(894, 86);
            this.tbDisX.Name = "tbDisX";
            this.tbDisX.Size = new System.Drawing.Size(100, 20);
            this.tbDisX.TabIndex = 5;
            this.tbDisX.Visible = false;
            this.tbDisX.WordWrap = false;
            // 
            // tbDisY
            // 
            this.tbDisY.Location = new System.Drawing.Point(894, 112);
            this.tbDisY.Name = "tbDisY";
            this.tbDisY.Size = new System.Drawing.Size(100, 20);
            this.tbDisY.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SchermCoords";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMidSpineZ);
            this.Controls.Add(this.txtMidSpineY);
            this.Controls.Add(this.txtMidSpineX);
            this.Controls.Add(this.tbDisY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDisX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMidSpineX;
        private System.Windows.Forms.TextBox txtMidSpineY;
        private System.Windows.Forms.TextBox txtMidSpineZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDisX;
        private System.Windows.Forms.TextBox tbDisY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

