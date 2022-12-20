using System.ComponentModel.DataAnnotations;

namespace Company.Common.DTOs
{
    public class SectionDTO
    {
        public int ID { get; set; }
        [MaxLength(50), Required] public string SectionName { get; set; }
        [Required] public int ACompanyID { get; set; }
    }
}
