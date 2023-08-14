﻿using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO{Id=1, Name="Pool View", Sqft = 100, Occupancy = 4},
            new VillaDTO{Id=2, Name="Beach View", Sqft = 200, Occupancy = 8},
            new VillaDTO{Id=3, Name="Park View", Sqft = 400, Occupancy = 12}
        };
    }
}
