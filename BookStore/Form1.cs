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
        private List<Book> booksInStore = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_click(object sender, EventArgs e)
        {
            var title = txtTitle.Text;
            var author = txtAuthor.Text;
            var isPrice = decimal.TryParse(txtPrice.Text, out var price);

            try
            {
                ValidateLength(title, 5);
                ValidateLength(author, 10);
                ValidateIsTrue(isPrice, "Inte ett giltigt pris");

                var book = new Book
                {
                    Author = author,
                    Title = title,
                    Price = price
                };

                booksInStore.Add(book);
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message, "Woops");
            }
            
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
