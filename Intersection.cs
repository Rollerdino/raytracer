using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace template
{
    class Intersection
    {
        public Vector3 Intersect(Primitive p, Ray r)
        {
            int type = p.getType();
            if (type == 1) {
                Vector3 v = r.origin - p.center;
                float b = -r.dotProduct(v, r.GetDirection());
                float det = (b * b) - r.dotProduct(v, v) + p.radius;
                if (det > 0)
                {
                    det = (float)Math.Sqrt(det);
                    float i1 = b - det;
                    float i2 = b + det;
                    if (i2 > 0)
                    {
                        if (i1 < 0)
                        {
                            if (i2 < r.maxDistance)
                            {
                                r.maxDistance = i2;
                                return new Vector3();
                            }

                        }
                        else
                        {
                            if (i1 < r.maxDistance)
                            {
                                r.maxDistance = i1;
                                return new Vector3(i1*r.direction.X, i1*r.direction.Y, i1*r.direction.Z);
                            }
                        }
                    }
                }
            } //sphere code
            if (type == 2) {                  //plane code
                float d = r.dotProduct(p.normal, r.GetDirection());
                if (d != 0)
                {
                    float dist = -(r.dotProduct(p.normal, r.origin) + p.init) / d;
                    if (dist > 0)
                    {
                        if (dist < r.maxDistance)
                        {
                            r.maxDistance = dist;
                            return new Vector3(dist*r.direction.X, dist*r.direction.Y, dist*r.direction.Z);
                        }
                    }
                }
            } 
            return new Vector3();
        }
    }
}
