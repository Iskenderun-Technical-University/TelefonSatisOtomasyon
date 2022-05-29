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
    public partial class FormStokTakip : Form
    {
        public FormStokTakip()
        {
            InitializeComponent();
            DataTable dt = sqlMethods.TelefonVeriCek();
            dataGridView1.DataSource = dt;
        }
        SqlMethods sqlMethods = new SqlMethods();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            btnGuncelleEkle.Text = "Ekle";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            btnGuncelleEkle.Text = "Güncelle";
        }

        string ID = "";
        private void btnGuncelleEkle_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Ekle")
            {
                Telefon telefon = new Telefon()
                {
                    marka = tbxMarka.Text,
                    model = tbxModel.Text,
                    dahiliHafiza = tbxDahiliHafiza.Text,
                    pilGucu = tbxPil.Text,
                    ekranBoyut = tbxEkran.Text,
                    ram = tbxRam.Text,
                    kameraCozunurluk = tbxKamera.Text,
                    mobilBaglantiTipi = tbxBaglanti.Text,
                    garanti = tbxGaranti.Text,
                    fiyat = tbxFiyat.Text
                };
                sqlMethods.TelefonEkle(telefon);

                DataTable dt = sqlMethods.TelefonVeriCek();
                dataGridView1.DataSource = dt;
                ID = "";
            }
            else if (btn.Text == "Güncelle")
            {
                if (!string.IsNullOrWhiteSpace(ID))
                {
                    Telefon telefon = new Telefon()
                    {
                        _ID = int.Parse(ID),
                        marka = tbxMarka.Text,
                        model = tbxModel.Text,
                        dahiliHafiza = tbxDahiliHafiza.Text,
                        pilGucu = tbxPil.Text,
                        ekranBoyut = tbxEkran.Text,
                        ram = tbxRam.Text,
                        kameraCozunurluk = tbxKamera.Text,
                        mobilBaglantiTipi = tbxBaglanti.Text,
                        garanti = tbxGaranti.Text,
                        fiyat = tbxFiyat.Text
                    };
                    sqlMethods.TelefonUpdate(telefon);
                    DataTable dt = sqlMethods.TelefonVeriCek();
                    dataGridView1.DataSource = dt;
                    ID = "";
                }
                else
                {
                    MessageBox.Show("Listeden bir ürün seçtikten sonra güncelleyiniz", "Hata");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxMarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxDahiliHafiza.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxPil.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxEkran.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxRam.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxKamera.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxBaglanti.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbxGaranti.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tbxFiyat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void tbxAra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxAra.Text))
            {
                dataGridView1.DataSource = sqlMethods.TelefonAra(tbxAra.Text);
            }
            else
            {
                dataGridView1.DataSource = sqlMethods.TelefonVeriCek();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ID))
            {
                sqlMethods.TelefonSil(int.Parse(ID));
                DataTable dt = sqlMethods.TelefonVeriCek();
                dataGridView1.DataSource = dt;
                ID = "";
            }
        }
    }
}
