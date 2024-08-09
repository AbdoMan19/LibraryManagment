namespace LibraryManagment.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateOnly CreationDate { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
        public ICollection<Borrow>? Borrows { get; set; }
    }
}
