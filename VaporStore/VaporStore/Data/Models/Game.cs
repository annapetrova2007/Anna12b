using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VaporStore.Data.Models
{
    public class Game
    {
        public Game() 
        {
            this.GamesTags = new HashSet<GameTag>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(0)]
        public decimal Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]

        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }    

        [Required]
       
        public string GenreId { get; set; }

        public Genre Genre { get; set; }

        public ICollection<GameTag> GamesTags { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
