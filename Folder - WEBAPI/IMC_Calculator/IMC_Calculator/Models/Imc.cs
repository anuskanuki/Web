﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMC_Calculator.Models
{
    public class Imc
    {
        public double ImcValue { get; set; } = 0;

        public double Weight { get; set; }
        public double Height { get; set; }

        public string Text { get; set; } = string.Empty;
    }
}