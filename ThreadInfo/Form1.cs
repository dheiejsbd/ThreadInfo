using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ThreadInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThreadInfo_Click(object sender, EventArgs e)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "ThreadInfo";
            tbThreadInfo.Text += "HashCode : " + th.GetHashCode() + "\r\n";
            tbThreadInfo.Text += "스레드 이름 : " + th.Name + "\r\n";
            tbThreadInfo.Text += "스레드 우선순위 : " + th.Priority + "\r\n";
            tbThreadInfo.Text += "스레드 상태 : " + th.ThreadState;

        }
    }
}
