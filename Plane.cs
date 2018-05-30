using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using OpenTK;

namespace template
{
    class Plane : Primitive
    {
        Vector3 normal;
        public override int getType()
        {
            return 2;
        }
        public override int Intersect(Ray r, float d)
        {
            float dd = 
        }

    }
}
