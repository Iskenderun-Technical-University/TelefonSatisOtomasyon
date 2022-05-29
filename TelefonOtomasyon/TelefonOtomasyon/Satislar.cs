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
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
            DataTable dt = sqlMethods.SatisVeriCek();
            dataGridView1.DataSource = dt;
        }
        SqlMethods sqlMethods = new SqlMethods();
        private void tbxAra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxAra.Text))
            {
                dataGridView1.DataSource = sqlMethods.SatisAra(tbxAra.Text);
            }
            else
            {
                dataGridView1.DataSource = sqlMethods.SatisVeriCek();
            }
        }
    }
}
