namespace WebApp3Layers.Data.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; } = null!;
        public virtual ICollection<BookCategory> BookCategories { get; set; } = null!;
    }
}
