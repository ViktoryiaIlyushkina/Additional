﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.Tuple
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public (int coordinateX, int coordinateY) GetCoordinates()
        {
            return (X , Y);
        }
    }
}
