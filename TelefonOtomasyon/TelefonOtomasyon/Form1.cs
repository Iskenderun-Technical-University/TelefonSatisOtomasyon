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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            FormAnasayfa anasayfa = new FormAnasayfa();
            PaneleYansit(anasayfa);
        }
        int x, y, move = 0;
        private void lblBar_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
                SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void btnStokTakip_Click(object sender, EventArgs e)
        {
            FormStokTakip formStokTakip = new FormStokTakip();
            formStokTakip.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Satislar satislar = new Satislar();
            satislar.Show();
        }

        private void lblBar_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        public void PaneleYansit(Form panelForm)
        {
            panel1.Controls.Clear();
            panelForm.TopLevel = false;
            panel1.Controls.Add(panelForm);
            panelForm.Show();
            panelForm.Dock = DockStyle.Bottom;
            panelForm.BringToFront();
        }
    }
}
