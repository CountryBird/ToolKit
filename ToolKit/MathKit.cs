using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKit
{
    public static class MathKit
    {
        public static double ClampMin(double value, double min) // 최소값 제한
        {
            return value < min ? min : value;
        }
        public static double ClampMax(double value, double max) // 최대값 제한
        {
            return value > max ? max : value;
        }
    }
}
