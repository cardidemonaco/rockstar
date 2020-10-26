using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace rockstar.Data.Entities
{
    public class Artist
    {
        [Key]
        [Required]
        public int ArtistID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string ArtistName { get; set; }
        [Display(Name = "Biography")]
        [DataType(DataType.MultilineText)]
        public string ArtistBiography { get; set; }
        [Display(Name = "Start of Career")]
        public DateTimeOffset? ArtistCareerStart { get; set; }
        [Display(Name = "End of Career")]
        public DateTimeOffset? ArtistCareerEnd { get; set; }
    }
}
