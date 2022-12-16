using Company.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class Employee : IEntity
    {
        public int ID { get; set; }

        [MaxLength(50), Required] public string FirstName { get; set; }

        [MaxLength(50), Required] public string LastName { get; set; }

        [MaxLength(50), Required] public decimal Salary { get; set; }

        public bool Union { get; set; }

        public virtual ICollection<Section>? Sections { get; set; }
    }
}
