using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act1_Parallax
{
    public partial class MAIN_FORM : Form
    {
        int motion1 = 2;
        int motion2 = 4;
        int motion3 = 8;
        int motion4 = 16;

        int width = 688;

        int l1_x1, l1_x2, l2_x1, l2_x2, l3_x1, l3_x2, l4_x1, l4_x2;

        Bitmap layer1, layer2, layer3, layer4;

        private void MAIN_FORM_Load(object sender, EventArgs e)
        {

        }

        bool right, hold = true;
        public MAIN_FORM()
        {
            InitializeComponent();

            layer1 = MyResource.CieloAzul;
            layer2 = MyResource.Nubes5;
            layer3 = MyResource.Arboles4;
            layer4 = MyResource.Pasto9;

            l1_x1 = l2_x1 = l3_x1 = l4_x1 = 0;
            l1_x2 = l2_x2 = l3_x2 = l4_x2 = width;

            PLAYER.Image = MyResource.PersonaHold;
        }

        private void PLAYER_Click(object sender, EventArgs e)
        {

        }

        static Graphics g;

        private void BackgroundMove()
        {
            if (l1_x1 < -width) { l1_x1 = width - motion1; }
            l1_x1 -= motion1; l1_x2 -= motion1;
            if (l1_x2 < -width) { l1_x2 = width - motion1; }

            if (l2_x1 < -width) { l2_x1 = width - motion2; }
            l2_x1 -= motion2; l2_x2 -= motion2;
            if (l2_x2 < -width) { l2_x2 = width - motion2; }

            if (l3_x1 < -width) { l3_x1 = width - motion3; }
            l3_x1 -= motion3; l3_x2 -= motion3;
            if (l3_x2 < -width) { l3_x2 = width - motion3; }

            if (l4_x1 < -width) { l4_x1 = width - motion4; }
            l4_x1 -= motion4; l4_x2 -= motion4;
            if (l4_x2 < -width) { l4_x2 = width - motion4; }

            Invalidate();
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            if (right)
            {
                BackgroundMove();
            }
        }

        private void MAIN_FORM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right & hold)
            {
                right = true;
                hold = false;
                PLAYER.Image = MyResource.Persona6;
            }
        }

        private void MAIN_FORM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right & !hold)
            {
                right = false;
                hold = true;
                PLAYER.Image = MyResource.PersonaHold;
            }
        }

        private void MAIN_FORM_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            g.DrawImage(layer1, l1_x1, 0, layer1.Width, this.Height - 50);
            g.DrawImage(layer1, l1_x2, 0, layer1.Width, this.Height - 50);

            g.DrawImage(layer2, l2_x1, 70, layer1.Width, this.Height - 150);
            g.DrawImage(layer2, l2_x2, 70, layer1.Width, this.Height - 150);

            g.DrawImage(layer3, l3_x1, 0, layer1.Width, this.Height - 50);
            g.DrawImage(layer3, l3_x2, 0, layer1.Width, this.Height - 50);

            g.DrawImage(layer4, l4_x1, 0, layer1.Width, this.Height - 50);
            g.DrawImage(layer4, l4_x2, 0, layer1.Width, this.Height - 50);
        }

        private void PLAYER_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
