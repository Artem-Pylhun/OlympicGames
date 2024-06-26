﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Entities
{
    public class City
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public int Population { get; set; }

        public override string ToString()
        {
            return $"{Title}, {Location}, Population: {Population}";
        }
    }
}
