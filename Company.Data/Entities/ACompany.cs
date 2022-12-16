using Company.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class ACompany : IEntity
    {
        public int ID { get; set; }
        [MaxLength(50), Required]  public string ACompanyName { get; set; }
        [MaxLength(50), Required] public int organizationnumber { get; set; }
    }
}
