using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeKhanhLy423.Models
{
    public class Nhanvien
    {
        [Key]
        public int IDNV { get; set;}
        public string? Fullname { get; set;}
        public int Tuoi { get; set;}
        public string? Chucvu { get; set;}
    }
}