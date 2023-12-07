using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet_week6
{
    internal class Rectangle
    {
        private float length, width;

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;

        }
        public float CalculateArea()
        {
            return this.length * this.width;
        }
    }
}
