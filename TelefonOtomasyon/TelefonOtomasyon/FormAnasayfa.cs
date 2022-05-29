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
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            FormTelefonlar tel = new FormTelefonlar();
            Form1 f = (Form1)Application.OpenForms["Form1"];
            f.PaneleYansit(tel);
        }
    }
}
