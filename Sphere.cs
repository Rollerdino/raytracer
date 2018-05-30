using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Template;

namespace template
{
    class Sphere : Primitive
    {
        float radius;
        public Sphere(Vector3 c, float r)
        {
            radius = r;
            Vector3 center = c;
            float sqradius = r * r;
            float rradius = 1 / r;
        }
        public override int getType() { return 1; }
        
        
    }
}
