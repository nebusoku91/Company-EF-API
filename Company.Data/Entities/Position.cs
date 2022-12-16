using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class Position : IEntity
    {

        public int ID { get; set; }

        public string PositionName { get; set; }
    }
}
