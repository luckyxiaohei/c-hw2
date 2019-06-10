using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    class hw2_4
    {
         public string hw2()
        {
            string[] m = Environment.GetCommandLineArgs(); 
            return m[1];
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hw2_4 hw = new hw2_4();
           string k = hw.hw2();
            MessageBox.Show(k);
        }
    }
}
