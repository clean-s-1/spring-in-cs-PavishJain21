﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class LEDAlert:IAlerter
    {
        public bool ledGlows { get; set; } = true;
    }
}
