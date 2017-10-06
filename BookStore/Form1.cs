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

                RedrawListBox();
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message, "Woops");
            }

        }

        private void RedrawListBox()
        {
            lstBooksInStore.Items.Clear();
            foreach (var item in booksInStore)
            {
                lstBooksInStore.Items.Add(item);
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

        private List<CartRow> cartRows = new List<CartRow>();

        private void btnBuy_Click(object sender, EventArgs e)
        {
            foreach (var item in lstBooksInStore.SelectedItems)
            {
                AddBookOrUpdateCount(item);
            }

            RedrawBoughtBooks();
            var sum = CalculateSum();
            lblSum.Text = sum.ToString("C");
        }

        private decimal CalculateSum()
        {
            decimal sum = 0;
            foreach (var row in cartRows)
            {
                sum += (row.Count * row.Book.Price);
            }
            return sum;
        }

        private void AddBookOrUpdateCount(object item)
        {
            var book = (Book)item;
            var newList = new List<CartRow>();
            var added = false;
            for (int i = 0; i < cartRows.Count; i++)
            {
                var cartRow = cartRows[i];
                if (cartRow.Book.Author == book.Author && cartRow.Book.Title == book.Title)
                {
                    added = true;
                    newList.Add(new CartRow { Book = book, Count = cartRow.Count + 1 });
                    break;
                }
            }
            if (!added)
                newList.Add(new CartRow { Book = book, Count = 1 });
            cartRows = newList;
        }

        private void RedrawBoughtBooks()
        {
            lstBoughtBooks.Items.Clear();
            foreach (var row in cartRows)
            {
                lstBoughtBooks.Items.Add(row);
            }
        }
    }
}
