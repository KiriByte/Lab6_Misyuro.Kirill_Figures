using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6_Misyuro.Kirill
{
    public class Circle : Rectangle
    {
        const float pi = (float)Math.PI;
        public float Radius { get; set; }

        public override float Perimetr { get { return 2 * pi * Radius; } }
        public override float Square { get { return 2 * pi * Radius * Radius; } }
    }
}