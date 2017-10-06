namespace BookStore
{
    struct CartRow
    {
        public Book Book;
        public int Count;

        public override string ToString()
        {
            return Book.ToString() + ", Antal: " + Count;
        }
    }
}
