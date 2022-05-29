using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonOtomasyon
{
    public partial class FormTelefonlar : Form
    {
        public FormTelefonlar()
        {
            InitializeComponent();



            foreach (var telefon in sqlMethods.TelefonListGet())
            {
                lbxTelefons.Items.Add(telefon._ID + "- " + telefon.marka + " " + telefon.model + " " + telefon.dahiliHafiza);

                //tbxMarka.Text = telefon.marka;
                //tbxModel.Text = telefon.model;
                //tbxDahiliHafiza.Text = telefon.dahiliHafiza;
                //tbxPil.Text = telefon.pilGucu;
                //tbxEkran.Text = telefon.ekranBoyut;
                //tbxRam.Text = telefon.ram;
                //tbxKamera.Text = telefon.kameraCozunurluk;
                //tbxBaglanti.Text = telefon.mobilBaglantiTipi;
                //tbxGaranti.Text = telefon.garanti;
                //tbxFiyat.Text = telefon.fiyat;
            }
        }
        SqlMethods sqlMethods = new SqlMethods();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];
            FormAnasayfa an = new FormAnasayfa();
            f.PaneleYansit(an);
        }

        private void lbxTelefons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTelefons.SelectedIndex > -1)
            {
                foreach (var telefon in sqlMethods.TelefonListGet())
                {
                    if (telefon._ID == int.Parse(lbxTelefons.SelectedItem.ToString().Split('-').First()))
                    {
                        tbxMarka.Text = telefon.marka;
                        tbxModel.Text = telefon.model;
                        tbxDahiliHafiza.Text = telefon.dahiliHafiza;
                        tbxPil.Text = telefon.pilGucu;
                        tbxEkran.Text = telefon.ekranBoyut;
                        tbxRam.Text = telefon.ram;
                        tbxKamera.Text = telefon.kameraCozunurluk;
                        tbxBaglanti.Text = telefon.mobilBaglantiTipi;
                        tbxGaranti.Text = telefon.garanti;
                        tbxFiyat.Text = telefon.fiyat;
                    }
                }
            }
        }
        public int satisID;
        private void pbxKabul_Click(object sender, EventArgs e)
        {
            if (lbxTelefons.SelectedIndex > -1)
            {
                satisID = int.Parse(lbxTelefons.SelectedItem.ToString().Split('-').First());
                FormSatis satis = new FormSatis();
                Form1 form = (Form1)Application.OpenForms["Form1"];
                form.PaneleYansit(satis);
            }
        }
    }
}
