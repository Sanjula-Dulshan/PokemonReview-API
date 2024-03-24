﻿namespace PokemonReview_API.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
} 