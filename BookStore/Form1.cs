using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_click(object sender, EventArgs e)
        {
            var title = txtTitle.Text;
            var author = txtAuthor.Text;
            var isPrice = decimal.TryParse(txtPrice.Text, out var price);

            ValidateLength(title, 5);
            ValidateLength(author, 10);
            ValidateIsTrue(isPrice, "Inte ett giltigt pris");
        }

        private void ValidateIsTrue(bool isPrice, string message)
        {
            if (isPrice != true)
                throw new ApplicationException(message);
        }

        private void ValidateLength(string input, int length)
        {
            if (input.Length < length)
                throw new ApplicationException("För kort.");
        }
    }
}
