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
    public partial class polus : UserControl
    {
        public Mem m = new Mem();
        public string yAddy = "GameAssembly.dll+028CE63C,5C,0,60,30,8,5C,30";
        public string xAddy = "GameAssembly.dll+028CE63C,5C,0,64,38,8,5C,2C";
        public polus()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "20.4");
            m.WriteMemory(yAddy, "float", "-11.8");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "19.6");
            m.WriteMemory(yAddy, "float", "-16.6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "23.9");
            m.WriteMemory(yAddy, "float", "-22.4");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "36.4");
            m.WriteMemory(yAddy, "float", "-19.4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "36.35");
            m.WriteMemory(yAddy, "float", "-7.3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "16.7");
            m.WriteMemory(yAddy, "float", "-2.1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "9.8");
            m.WriteMemory(yAddy, "float", "-12.4");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "2.9");
            m.WriteMemory(yAddy, "float", "-12.4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "4.6");
            m.WriteMemory(yAddy, "float", "-21.2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "15.4");
            m.WriteMemory(yAddy, "float", "-0.5");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "15.4");
            m.WriteMemory(yAddy, "float", "-0.5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "15.4");
            m.WriteMemory(yAddy, "float", "-0.5");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "2.3");
            m.WriteMemory(yAddy, "float", "-24.1");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "12");
            m.WriteMemory(yAddy, "float", "-16.8");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "12.2");
            m.WriteMemory(yAddy, "float", "-23.6");
        }
    }
}
