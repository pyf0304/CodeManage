using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.math
{
    public class MathGeometry
    {
        public static double AngelBetweenTwo2DVector(Vector vector1, Vector vector2)
        {
            return Vector.AngleBetween(vector1, vector2);
        }


    }
}
