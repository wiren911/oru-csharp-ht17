﻿using System;
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
        private List<string> enteredStrings = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var enteredString = ConcatStrings(textBox1.Text, textBox2.Text);
            enteredStrings.Add(enteredString);

            label1.Text = enteredString;
            RedrawListBox();
        }

        private void RedrawListBox()
        {
            listBox1.Items.Clear();

            foreach (var item in enteredStrings)
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
            var items = listBox1.SelectedItems;
            foreach (var item in items)
            {
                enteredStrings.Remove(item.ToString());
            }
            RedrawListBox();
        }
    }
}
