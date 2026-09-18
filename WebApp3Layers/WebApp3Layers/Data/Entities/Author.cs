namespace WebApp3Layers.Data.Entities
{
    public class Author:BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int BiographyId { get; set; }
        public virtual Biography Biography { get; set; } = null!;
    }
}
