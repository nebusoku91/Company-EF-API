namespace Company.Data.Entities;

public class Employee : IEntity
{
    public int ID { get; set; }
    [MaxLength(50)] public string? FirstName { get; set; }
    [MaxLength(50)] public string? LastName { get; set; }
    public int? Salary { get; set; }
    public bool? Union { get; set; }
    public int SectionID { get; set; }
    public virtual Section? Section { get; set; }
    public virtual ICollection<Position>? Position { get; set; }
}
