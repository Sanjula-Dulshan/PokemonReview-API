﻿using AutoMapper;
using PokemonReview_API.Dto;
using PokemonReview_API.Models;

namespace PokemonReview_API.Helper
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();

        }
    }
}