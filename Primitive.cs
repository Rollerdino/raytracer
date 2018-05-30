using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace template
{
    abstract class Primitive
    {
        public float init;
        public Vector3 normal;
        public Vector3 center;
        public float radius;
        public virtual int getType()
        {
            return 0;
        }
        public virtual int Intersect(Ray r, float d)
        {
            return 0;  
        }
    }
}
