namespace BookStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.numInStock = new System.Windows.Forms.NumericUpDown();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lstBooksInStore = new System.Windows.Forms.ListBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lstBoughtBooks = new System.Windows.Forms.ListBox();
            this.lblSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(12, 38);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 64);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(47, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // numInStock
            // 
            this.numInStock.Location = new System.Drawing.Point(65, 64);
            this.numInStock.Name = "numInStock";
            this.numInStock.Size = new System.Drawing.Size(47, 20);
            this.numInStock.TabIndex = 3;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 90);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 23);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // lstBooksInStore
            // 
            this.lstBooksInStore.FormattingEnabled = true;
            this.lstBooksInStore.Location = new System.Drawing.Point(118, 12);
            this.lstBooksInStore.Name = "lstBooksInStore";
            this.lstBooksInStore.Size = new System.Drawing.Size(299, 95);
            this.lstBooksInStore.TabIndex = 5;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(218, 113);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 23);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lstBoughtBooks
            // 
            this.lstBoughtBooks.FormattingEnabled = true;
            this.lstBoughtBooks.Location = new System.Drawing.Point(118, 142);
            this.lstBoughtBooks.Name = "lstBoughtBooks";
            this.lstBoughtBooks.Size = new System.Drawing.Size(299, 95);
            this.lstBoughtBooks.TabIndex = 7;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(166, 240);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(35, 13);
            this.lblSum.TabIndex = 8;
            this.lblSum.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 346);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lstBoughtBooks);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lstBooksInStore);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.numInStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown numInStock;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ListBox lstBooksInStore;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox lstBoughtBooks;
        private System.Windows.Forms.Label lblSum;
    }
}

