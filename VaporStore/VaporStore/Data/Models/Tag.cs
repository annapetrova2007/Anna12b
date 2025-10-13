using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore.Data.Models
{
    public class Tag
    {
        public Tag() 
        { 
            this.GamesTags = new HashSet<GameTag>();
        }    
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public ICollection<GameTag> GamesTags { get; set; }  
        public ICollection<Tag> Tags { get; set; }
    }
}
