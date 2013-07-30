﻿using System;
using System.Collections.Generic;
using EventEgg.Service.Interfaces;

namespace EventEgg.Service.Models
{
    public class CountryViewModel : IViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public IList<CityViewModel> Cities { get; set; }

        public CountryViewModel()
        {
            Cities = new List<CityViewModel>();
        }
    }
}
