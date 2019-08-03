﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubrania_ASP.NET_Nowy.Models
{
    public class AnnualReport
    {
        public int Id { get; set; }
        public DateTime Year { get; set; }
        public int Balance { get; set; }
        public List<Cloth> Clothes { get; set; }
    }
}
