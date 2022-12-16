using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class Section : IEntity
    {
        public int ID { get; set; }

        [MaxLength(50), Required] public string SectionName { get; set; }
        [MaxLength(50), Required] public int ACompanyID { get; set; }

    }
}
