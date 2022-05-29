
namespace TelefonOtomasyon
{
    partial class FormStokTakip
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelleEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAra = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.tbxGaranti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxBaglanti = new System.Windows.Forms.TextBox();
            this.tbxKamera = new System.Windows.Forms.TextBox();
            this.tbxRam = new System.Windows.Forms.TextBox();
            this.tbxEkran = new System.Windows.Forms.TextBox();
            this.tbxPil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDahiliHafiza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxMarka = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 444);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(776, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stok";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuncelleEkle
            // 
            this.btnGuncelleEkle.Location = new System.Drawing.Point(807, 439);
            this.btnGuncelleEkle.Name = "btnGuncelleEkle";
            this.btnGuncelleEkle.Size = new System.Drawing.Size(224, 23);
            this.btnGuncelleEkle.TabIndex = 7;
            this.btnGuncelleEkle.Text = "Güncelle / Ekle";
            this.btnGuncelleEkle.UseVisualStyleBackColor = true;
            this.btnGuncelleEkle.Click += new System.EventHandler(this.btnGuncelleEkle_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(649, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ara:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxAra
            // 
            this.tbxAra.Location = new System.Drawing.Point(684, 11);
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(100, 20);
            this.tbxAra.TabIndex = 9;
            this.tbxAra.TextChanged += new System.EventHandler(this.tbxAra_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(807, 37);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Telefon Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(920, 37);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Telefon Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(823, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Fiyat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(823, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Garanti:";
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(903, 365);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(120, 20);
            this.tbxFiyat.TabIndex = 37;
            this.tbxFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxGaranti
            // 
            this.tbxGaranti.Location = new System.Drawing.Point(903, 305);
            this.tbxGaranti.Name = "tbxGaranti";
            this.tbxGaranti.Size = new System.Drawing.Size(100, 20);
            this.tbxGaranti.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(823, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Bağlantı Tipi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(823, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Kamera Çöz.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(823, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ram:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(823, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Ekran Boyutu:";
            // 
            // tbxBaglanti
            // 
            this.tbxBaglanti.Location = new System.Drawing.Point(903, 281);
            this.tbxBaglanti.Name = "tbxBaglanti";
            this.tbxBaglanti.Size = new System.Drawing.Size(100, 20);
            this.tbxBaglanti.TabIndex = 31;
            // 
            // tbxKamera
            // 
            this.tbxKamera.Location = new System.Drawing.Point(903, 255);
            this.tbxKamera.Name = "tbxKamera";
            this.tbxKamera.Size = new System.Drawing.Size(100, 20);
            this.tbxKamera.TabIndex = 30;
            // 
            // tbxRam
            // 
            this.tbxRam.Location = new System.Drawing.Point(903, 229);
            this.tbxRam.Name = "tbxRam";
            this.tbxRam.Size = new System.Drawing.Size(100, 20);
            this.tbxRam.TabIndex = 29;
            // 
            // tbxEkran
            // 
            this.tbxEkran.Location = new System.Drawing.Point(903, 203);
            this.tbxEkran.Name = "tbxEkran";
            this.tbxEkran.Size = new System.Drawing.Size(100, 20);
            this.tbxEkran.TabIndex = 28;
            // 
            // tbxPil
            // 
            this.tbxPil.Location = new System.Drawing.Point(903, 177);
            this.tbxPil.Name = "tbxPil";
            this.tbxPil.Size = new System.Drawing.Size(100, 20);
            this.tbxPil.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(823, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Pil Gücü:";
            // 
            // tbxDahiliHafiza
            // 
            this.tbxDahiliHafiza.Location = new System.Drawing.Point(903, 153);
            this.tbxDahiliHafiza.Name = "tbxDahiliHafiza";
            this.tbxDahiliHafiza.Size = new System.Drawing.Size(100, 20);
            this.tbxDahiliHafiza.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dahili Hafıza:";
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(903, 127);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 20);
            this.tbxModel.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(823, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Model:";
            // 
            // tbxMarka
            // 
            this.tbxMarka.Location = new System.Drawing.Point(903, 101);
            this.tbxMarka.Name = "tbxMarka";
            this.tbxMarka.Size = new System.Drawing.Size(100, 20);
            this.tbxMarka.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(823, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Marka:";
            // 
            // FormStokTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 474);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxFiyat);
            this.Controls.Add(this.tbxGaranti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxBaglanti);
            this.Controls.Add(this.tbxKamera);
            this.Controls.Add(this.tbxRam);
            this.Controls.Add(this.tbxEkran);
            this.Controls.Add(this.tbxPil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxDahiliHafiza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxMarka);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbxAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuncelleEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormStokTakip";
            this.Text = "StokTakip";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelleEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbxFiyat;
        public System.Windows.Forms.TextBox tbxGaranti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbxBaglanti;
        public System.Windows.Forms.TextBox tbxKamera;
        public System.Windows.Forms.TextBox tbxRam;
        public System.Windows.Forms.TextBox tbxEkran;
        public System.Windows.Forms.TextBox tbxPil;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbxDahiliHafiza;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tbxMarka;
        private System.Windows.Forms.Label label12;
    }
}