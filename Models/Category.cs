using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScarsMotorGarage.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }    
        public int DisplayOrder { get; set; }   
        public DateTime createdTime { get; set; } = DateTime.Now;
    }
}