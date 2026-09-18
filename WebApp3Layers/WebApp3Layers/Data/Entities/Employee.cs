namespace WebApp3Layers.Data.Entities;

public class Employee:BaseEntity
{
    public string Name  { get; set; }
    public int CompanyId { get; set; }
    public virtual Company Company { get; set; } = null!;
}