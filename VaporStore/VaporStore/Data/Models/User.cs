using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]

        public string Username { get; set; }

        [Required]
        public string Fullname { get; set; }

        [Required]

        public string Email { get; set; }

        [Required]
        [MaxLength(103)]
        [MinLength(3)]

        public int Age { get; set; }

        public ICollection<User> Users { get; set; }   
    }
}
