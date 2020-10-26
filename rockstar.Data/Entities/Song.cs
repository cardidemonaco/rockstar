using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace rockstar.Data.Entities
{
    public class Song
    {
        [Key]
        [Required]
        public int SongID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string SongName { get; set; }
        [Display(Name = "Description")]
        public string SongDescription { get; set; }
        [Display(Name = "Length (seconds)")]
        public int SongLength { get; set; } //seconds
        [Required]
        [Display(Name = "Album")]
        public int AlbumID { get; set; }
        public Album Album { get; set; }
    }
}
