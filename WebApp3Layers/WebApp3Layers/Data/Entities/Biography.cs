namespace WebApp3Layers.Data.Entities
{
    public class Biography:BaseEntity
    {
        public string BiographyData { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; } = null!;
    }
}
