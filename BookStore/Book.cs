namespace BookStore
{
    struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;

        public override string ToString()
        {
            return $"Author: {Author}, Title: {Title}, Price: {Price}";
        }
    }
}
