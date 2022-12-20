using System.ComponentModel.DataAnnotations;

namespace Company.Common.DTOs;

public class EmployeeDTO
{
    public int ID { get; set; }
    [MaxLength(50)] public string? FirstName { get; set; }
    [MaxLength(50)] public string? LastName { get; set; }
    public int? Salary { get; set; }
    public bool? Union { get; set; }
    public int SectionID { get; set; }
}
//public class EmployeeInsertDTO
//{
//    [MaxLength(50)] public string? FirstName { get; set; }
//    [MaxLength(50)] public string? LastName { get; set; }
//    public int? Salary { get; set; }
//    public bool? Union { get; set; }
//    public int SectionID { get; set; }
//}

//public class EmployeeUpdateDTO : EmployeeInsertDTO
//{
//    public int ID { get; set; }
//}