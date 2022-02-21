﻿using System.ComponentModel.DataAnnotations;
namespace SongApi.Models
{
    public class Song
    {
        //properties
        public int Id { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int? Length { get; set; }
        [Required]
        public string? Genre { get; set; }

    }
}
