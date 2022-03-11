using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRepository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> num  = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                num.Add(i * i);
            }
            listBox1.DataSource = num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> num = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                num.Add(i * 5);
            }
            listBox1.DataSource = num;
        }
    }
}
