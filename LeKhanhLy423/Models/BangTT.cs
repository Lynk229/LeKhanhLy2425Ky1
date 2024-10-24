using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace LeKhanhLy423.Models
{ 
    public class BangTT
    {
        [Key]
        public int ID { get; set; }
        public string? Fullname { get; set; }
        public int Tuoi { get; set; }
        public string? Address { get; set; }

    }
}  