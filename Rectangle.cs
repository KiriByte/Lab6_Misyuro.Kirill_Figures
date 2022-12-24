using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6_Misyuro.Kirill
{
    public class Rectangle : Triangle
    {
        public float B { get; set; }

        public override float Perimetr { get { return 2 * (A + B); } }

        public override float Square { get { return A * B; } }
    }
}