using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class EmployeePosition : IReferenceEntity
    {
        public int EmployeeID { get; set; }
        public virtual Employee? Employee { get; set; }
        public int PositionID { get; set; }
        public virtual Position? Position { get; set; }

    }
}
