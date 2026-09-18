namespace WebApp3Layers.Data.Entities
{
    public class Book:BaseEntity
    {
        public string Title { get; set; } = null!;
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; } = null!;
        public virtual ICollection<BookCategory> BooksCategories { get; set; } = null!;
    }
}
