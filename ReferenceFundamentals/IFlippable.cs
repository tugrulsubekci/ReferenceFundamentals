﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceFundamentals
{
    internal interface IFlippable
    {
        int CurrentPage { get; set; }
        void Flip();
    }
}
