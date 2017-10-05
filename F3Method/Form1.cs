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
        public DateTime AuthoringDate;

        public override string ToString()
        {
            return $"{AuthoringDate}: {Author}: {Title}";
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
            try
            {
                ValidateLength(textBox1.Text, 5);
                ValidateLength(textBox2.Text, 10);
                var bok = new Bok
                {
                    Author = textBox1.Text,
                    Title = textBox2.Text,
                    AuthoringDate = dateTimePicker1.Value
                };
                enteredBooks.Add(bok);

                label1.Text = bok.Title;
                RedrawListBox();
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ValidateLength(string text, int v)
        {
            if (text.Length < v)
                throw new ApplicationException($"{text} är för kort, {v} krävs.");
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
