using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Blog.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(50)]

        public string password { get; set; }
        [Required(ErrorMessage = "please enter your age")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter your age")]
        [Range(1, 100)]
        public int? Age { get; set; }
        
    }
}