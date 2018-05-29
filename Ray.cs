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
        public Ray(Vector3 d)
        {
            direction = d;
            for (float i = 0; i < maxDistance; i = i + 0.05f)
            {
                //run intersection code
            }
        }
        

    }
}
