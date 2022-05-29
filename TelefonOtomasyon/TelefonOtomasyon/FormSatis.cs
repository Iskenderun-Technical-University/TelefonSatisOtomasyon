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
    public partial class FormSatis : Form
    {
        public FormSatis()
        {
            InitializeComponent();
        }

        private void pbxHome_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];
            FormAnasayfa an = new FormAnasayfa();
            f.PaneleYansit(an);
        }
        SqlMethods sqlMethods = new SqlMethods();
        FormTelefonlar frmTel = (FormTelefonlar)Application.OpenForms["FormTelefonlar"];
        private void rbtnNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNakit.Checked)
            {
                lblOdeme.Text = "Ödeme: " + sqlMethods.TelefonGetir(frmTel.satisID).fiyat;
            }
        }

        private void rbtn6Taksit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn6Taksit.Checked)
            {
                float odeme = (float.Parse(sqlMethods.TelefonGetir(frmTel.satisID).fiyat) / 6) + 19;
                lblOdeme.Text = "Ödeme: 12x" + odeme.ToString() + "  Toplam " + (Convert.ToDecimal(sqlMethods.TelefonGetir(frmTel.satisID).fiyat) + (6 * 19));
            }
        }

        private void rbtn12Taksit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn12Taksit.Checked)
            {
                float odeme = (float.Parse(sqlMethods.TelefonGetir(frmTel.satisID).fiyat) / 12)+29;
                lblOdeme.Text = "Ödeme: 12x" + odeme.ToString() +"  Toplam "+ (Convert.ToDecimal(sqlMethods.TelefonGetir(frmTel.satisID).fiyat)+(12*29));
            }
        }

        private void pbxKabul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxTC.Text) && !string.IsNullOrWhiteSpace(tbxIsim.Text)&& !string.IsNullOrWhiteSpace(tbxSoyisim.Text)&& !string.IsNullOrWhiteSpace(tbxTelefon.Text)&& (rbtn12Taksit.Checked || rbtn6Taksit.Checked || rbtnNakit.Checked))
            {
                Telefon tel = sqlMethods.TelefonGetir(frmTel.satisID);
                sqlMethods.SatisYap(tbxTC.Text, tbxIsim.Text, tbxSoyisim.Text, tbxTelefon.Text, tel.marka, tel.model, tel.dahiliHafiza.Trim(), lblOdeme.Text.Split(' ').Last());
                sqlMethods.TelefonSil(frmTel.satisID);
                MessageBox.Show("Telefon satış işlemi başarılı. İyi günlerde kullanın :)","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form1 f = (Form1)Application.OpenForms["Form1"];
                FormAnasayfa anasayfa = new FormAnasayfa();
                f.PaneleYansit(anasayfa);
            }
            else
            {
                MessageBox.Show("Alanları eksiksiz doldurunuz. Ödemen yöntemini de seçmeyi unutmayınız...", "Hata");
            }
        }
    }
}
