using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using System.Numerics;

namespace template
{
    class Ray
    {
        Vector3 origin = new Vector3(0, 0, 0);
        Vector3 direction;
        float maxDistance = 5;
        public Ray(Vector3 d)      //this determines the behavior of the ray every tick
        {
                
            //run intersection code
        }
        float dotProduct(Vector3 original, Vector3 direction) // this calculates the dot product of two vectors 
        {
            float length = (original.X * direction.X + original.Y * direction.Y + original.Z * direction.Z);
            return length;
        }
        

    }
}
