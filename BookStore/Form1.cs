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
            var amount = numInStock.Value;
            try
            {
                ValidateLength(title, 5);
                ValidateLength(author, 10);
                ValidateIsTrue(isPrice, "Inte ett giltigt pris");

                var book = new Book
                {
                    Author = author,
                    Title = title,
                    Price = price,
                    AmountInStore = (int)amount
                };

                booksInStore.Add(book);

                RedrawAvailableBooks();
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message, "Woops");
            }

        }

        private void RedrawAvailableBooks()
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
            try
            {
                foreach (var item in lstBooksInStore.SelectedItems)
                {
                    var book = (Book)item;
                    ReduceAmountInStoreForBook(book);
                    AddBookOrUpdateCount(book);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            RedrawAvailableBooks();
            RedrawBoughtBooks();
            RedrawSum();
        }

        private void ReduceAmountInStoreForBook(Book book)
        {
            if (book.AmountInStore == 0)
                throw new ApplicationException("Out of stock!");


            booksInStore.Remove(book);
            book.AmountInStore--;
            booksInStore.Add(book);
        }

        private void RedrawSum()
        {
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

        private void AddBookOrUpdateCount(Book book)
        {
            
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in lstBoughtBooks.SelectedItems)
            {
                var row = (CartRow)item;
                cartRows.Remove(row);
                if (row.Count > 1)
                {
                    row.Count--;
                    cartRows.Add(row);
                }
            }
            RedrawBoughtBooks();
            RedrawSum();

        }
    }
}
