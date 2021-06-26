using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mira1.Hide();
            polus1.Hide();
            skeld1.Show();
            skeld1.BringToFront();
        }

        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mira1.Hide();
            polus1.Hide();
            skeld1.Show();
            skeld1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mira1.Show();
            polus1.Hide();
            skeld1.Hide();
            mira1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mira1.Hide();
            polus1.Show();
            skeld1.Hide();
            polus1.BringToFront();
        }

        private void mira1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
