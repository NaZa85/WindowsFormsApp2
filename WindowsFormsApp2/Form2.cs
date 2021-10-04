using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
            listBox1.Items.Add(DateTime.Now.ToString("MM/dd/yyyy"));
            listBox1.Items.Add(DateTime.Now.ToString("HH:mm:ss"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox3.Text = (" ");
        }
    }
}
