﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenegmentSistyem.Models
{
    public class Book : LibraryItem
    {
        public string Genre { get; set; }
        public override void DisplayInfo()
        {
        }
    }
}
