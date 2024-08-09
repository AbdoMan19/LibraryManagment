using System;
namespace LibraryManagment.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly date { get; set; }

        public ICollection<Borrow>? Borrows { get; set; }
    }
}
