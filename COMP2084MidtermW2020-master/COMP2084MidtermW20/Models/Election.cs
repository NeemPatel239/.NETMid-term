﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084MidtermW20.Models
{
    public class Election
    {
        public Election()
        {
            ElectionId = 0;
            Year = 0;
            PartyId = 0;
            Majority = true;
        }
        public int ElectionId { get; set; }
        public int Year { get; set; }
        public int PartyId { get; set; }
        public bool? Majority { get; set; }

        [ForeignKey("PartyId")]
        [InverseProperty("Election")]
        public virtual Party Party { get; set; }
    }
}
