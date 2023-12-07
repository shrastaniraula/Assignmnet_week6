using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet_week6
{
    internal class Shape
    {
        public virtual int CalculateArea(int radius)
        {
            return 0;
        }
    }
    class Circle : Shape
    {

        public override int CalculateArea(int radius)
        {
            return 22 / 7 * radius * radius;
        }
    }
}
