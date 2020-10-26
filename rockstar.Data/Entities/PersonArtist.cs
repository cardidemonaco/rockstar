using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace rockstar.Data.Entities
{
    public class PersonArtist
    {
        [Key]
        [Required]
        public int PersonArtistID { get; set; }
        public int PersonID { get; set; } //FK
        public Person Person { get; set; } //FK
        public int ArtistID { get; set; } //FK
        public Artist Artist { get; set; } //FK
    }
}
