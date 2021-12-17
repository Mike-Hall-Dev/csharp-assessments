﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chaper_20
{
    public class Triangle : Shape
    {
        public Triangle(double height, double baseWidth) : base(height, baseWidth)
        { }

        public override double CalculateSurface()
        {
            return .5 * Height * Width;
        }
    }
}
