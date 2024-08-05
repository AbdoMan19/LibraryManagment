namespace LibraryManagment.Models
{
    public class Author {
   
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly BirthDate {  get; set; }

        public ICollection<Book>Books { get; set; }
    }
}
