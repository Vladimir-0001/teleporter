using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleporter
{
    public partial class mira : UserControl
    {
        public Mem m = new Mem();
        public string yAddy = "GameAssembly.dll+028CE63C,5C,0,60,30,8,5C,30";
        public string xAddy = "GameAssembly.dll+028CE63C,5C,0,64,38,8,5C,2C";

        public mira()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "14.7");
            m.WriteMemory(yAddy, "float", "19.3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "25.4");
            m.WriteMemory(yAddy, "float", "1.9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "23.7");
            m.WriteMemory(yAddy, "float", "-1.9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "19.7");
            m.WriteMemory(yAddy, "float", "4");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "15.5");
            m.WriteMemory(yAddy, "float", "3.8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "6.1");
            m.WriteMemory(yAddy, "float", "0.9");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "9.6");
            m.WriteMemory(yAddy, "float", "12.6");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "2.4");
            m.WriteMemory(yAddy, "float", "10.9");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "15.4");
            m.WriteMemory(yAddy, "float", "-0.5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "-4.4");
            m.WriteMemory(yAddy, "float", "3.0");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "21");
            m.WriteMemory(yAddy, "float", "20");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "17.7");
            m.WriteMemory(yAddy, "float", "23.3");
        }
    }
}
