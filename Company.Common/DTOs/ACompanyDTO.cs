using System.ComponentModel.DataAnnotations;

namespace Company.Common.DTOs;

public class ACompanyDTO
{
    public int ID { get; set; }
    [MaxLength(50), Required] public string ACompanyName { get; set; }
    [Required] public int OrganizationNumber { get; set; }
}
