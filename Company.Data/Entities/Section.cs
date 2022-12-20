namespace Company.Data.Entities;

public class Section : IEntity
{
    public int ID { get; set; }
    [MaxLength(50), Required] public string SectionName { get; set; }
    [Required] public int ACompanyID { get; set; }
    public virtual ACompany? Company { get; set; }
}
