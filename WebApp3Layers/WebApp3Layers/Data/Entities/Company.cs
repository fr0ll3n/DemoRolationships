namespace WebApp3Layers.Data.Entities;

public class Company:BaseEntity
{
    public string Name { get; set; } = null!;
    public virtual ICollection<Employee> Employees { get; set; } = null!;
}