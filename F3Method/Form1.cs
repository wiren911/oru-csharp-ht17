using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F3Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ConcatStrings(textBox1.Text, textBox2.Text);
        }

        private string ConcatStrings(params string[] strings)
        {
            return string.Join("", strings);
        }

        private string ConcatStrings(out DateTime date, params string[] strings)
        {
            date = DateTime.Now;
            return ConcatStrings(strings)
        }
    }
}
