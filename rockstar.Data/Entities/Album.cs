using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace rockstar.Data.Entities
{
    public class Album
    {
        [Key]
        [Required]
        [Display(Name = "Album")]
        public int AlbumID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string AlbumName { get; set; }
        [Display(Name = "Description")]
        public string AlbumDescription { get; set; }
        [Display(Name = "Release Date")]
        public DateTimeOffset? AlbumReleaseDate { get; set; }
        public string AlbumCoverURL { get; set; }
        [Required]
        [Display(Name = "Artist")]
        public int ArtistID { get; set; } //FK
        //public Artist Artist { get; set; }

        //public string AlbumWithArtist
        //{
        //    get
        //    {
        //        return $"{AlbumName} - {Artist.ArtistName}";
        //    }
        //}

        public ICollection<Song> Songs { get; set; }
    }
}
