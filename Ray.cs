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
        public Vector3 origin = new Vector3(0, 0, 0);
        public Vector3 direction;
        public float maxDistance = 10;
        Intersection i;
        public Vector3 intersectPlane;
        public Vector3 intersectSphere1;
        public Vector3 intersectSphere2;
        public Vector3 intersectSphere3;
        public Ray(Vector3 d, Scene s)      //this determines the behavior of the ray every tick
        {
            direction = d;
            intersectPlane = i.Intersect(s.plane, this);
            intersectSphere1 = i.Intersect(s.sphere1, this);
            intersectSphere2 = i.Intersect(s.sphere2, this);
            intersectSphere3 = i.Intersect(s.sphere3, this);
            //run intersection code
        }
        public float dotProduct(Vector3 original, Vector3 direction) // this calculates the dot product of two vectors 
        {
            float length = (original.X * direction.X + original.Y * direction.Y + original.Z * direction.Z);
            return length;
        }
        public Vector3 GetDirection()
        {
            return direction;
        }
        

    }
}
