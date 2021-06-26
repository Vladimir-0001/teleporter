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
using Memory;
namespace Teleporter
{
    public partial class skeld : UserControl
    {


        public Mem m = new Mem();
        public string yAddy = "GameAssembly.dll+028CE63C,5C,0,60,30,8,5C,30";
        public string xAddy = "GameAssembly.dll+028CE63C,5C,0,64,38,8,5C,2C";
        public skeld()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "1");
            m.WriteMemory(yAddy, "float", "1");
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "9");
            m.WriteMemory(yAddy, "float", "2.4");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "7");
            m.WriteMemory(yAddy, "float", "-3.5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "-1");
            m.WriteMemory(yAddy, "float", "-16");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "-9.1");
            m.WriteMemory(yAddy, "float", "-4");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "4.3");
            m.WriteMemory(yAddy, "float", "-7.5");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "17");
            m.WriteMemory(yAddy, "float", "-5");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "8");
            m.WriteMemory(yAddy, "float", "-14.7");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "5");
            m.WriteMemory(yAddy, "float", "-15");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "-7");
            m.WriteMemory(yAddy, "float", "-10");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "-15.5");
            m.WriteMemory(yAddy, "float", "-11.8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "-21");
            m.WriteMemory(yAddy, "float", "-5.8");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "-13");
            m.WriteMemory(yAddy, "float", "-3.8");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            m.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            m.WriteMemory(xAddy, "float", "-15.4");
            m.WriteMemory(yAddy, "float", "0.9");
        }
    }
}
