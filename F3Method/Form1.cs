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
    struct Bok
    {
        public string Author;
        public string Title;
        public override string ToString()
        {
            return Author;
        }
    }
    public partial class Form1 : Form
    {
        private List<Bok> enteredBooks = new List<Bok>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bok = new Bok { Author = textBox1.Text, Title = textBox2.Text };
            enteredBooks.Add(bok);

            label1.Text = bok.Title;
            RedrawListBox();
        }

        private void RedrawListBox()
        {
            listBox1.Items.Clear();

            foreach (var item in enteredBooks)
            {
                listBox1.Items.Add(item);
            }
        }

        private string ConcatStrings(params string[] strings)
        {
            return string.Join("", strings);
        }

        private string ConcatStrings(out DateTime date, params string[] strings)
        {
            date = DateTime.Now;
            return ConcatStrings(strings);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                enteredBooks.Remove((Bok)item);
            }
            RedrawListBox();
        }
    }
}
