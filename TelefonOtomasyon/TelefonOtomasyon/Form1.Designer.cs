
namespace TelefonOtomasyon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStokTakip = new System.Windows.Forms.PictureBox();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStokTakip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 405);
            this.panel1.TabIndex = 4;
            // 
            // lblBar
            // 
            this.lblBar.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblBar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBar.Location = new System.Drawing.Point(-3, 0);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(756, 36);
            this.lblBar.TabIndex = 5;
            this.lblBar.Text = "        Telefon Sepetim";
            this.lblBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBar_MouseDown);
            this.lblBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBar_MouseMove);
            this.lblBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Image = global::TelefonOtomasyon.Properties.Resources.payIt;
            this.pictureBox1.Location = new System.Drawing.Point(647, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnStokTakip
            // 
            this.btnStokTakip.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnStokTakip.Image = global::TelefonOtomasyon.Properties.Resources.admin;
            this.btnStokTakip.Location = new System.Drawing.Point(682, 6);
            this.btnStokTakip.Name = "btnStokTakip";
            this.btnStokTakip.Size = new System.Drawing.Size(29, 25);
            this.btnStokTakip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStokTakip.TabIndex = 6;
            this.btnStokTakip.TabStop = false;
            this.btnStokTakip.Click += new System.EventHandler(this.btnStokTakip_Click);
            // 
            // pbxExit
            // 
            this.pbxExit.BackColor = System.Drawing.SystemColors.ControlText;
            this.pbxExit.Image = global::TelefonOtomasyon.Properties.Resources.exit;
            this.pbxExit.Location = new System.Drawing.Point(717, 6);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(29, 25);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxExit.TabIndex = 4;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox2.Image = global::TelefonOtomasyon.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(185)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(752, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStokTakip);
            this.Controls.Add(this.pbxExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStokTakip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.PictureBox btnStokTakip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

