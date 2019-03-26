using System;
using System.Windows.Forms;

namespace Screen_resolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = SystemInformation.PrimaryMonitorSize.Width.ToString();
            textBox2.Text = SystemInformation.PrimaryMonitorSize.Height.ToString();
        }
    }
}