using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LeKhanhLy423.Models
{

    public class Employee
    {
        [Key]
        public int EmployeeID { get; set;}
        public string? Fullname { get; set;}
        public string? Tuoi { get; set;}

    }
}