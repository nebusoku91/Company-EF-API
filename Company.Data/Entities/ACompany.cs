namespace Company.Data.Entities;

public class ACompany : IEntity
{
    public int ID { get; set; }
    [MaxLength(50), Required] public string ACompanyName { get; set; }
    [Required] public int OrganizationNumber { get; set; }
    public virtual ICollection<Section>? Sections { get; set; }
}
