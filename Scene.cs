using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Template;
using OpenTK;

namespace template
{
    class Scene
    {
        public Camera camera;
        static Vector3 v;
        public int primNumber = 4;
        Surface Screen = new Surface(512, 512);
        //3 spheres, 1 plane
        public Sphere sphere1 = new Sphere(new Vector3(0,0,5), 1);
        public Sphere sphere2 = new Sphere(new Vector3(0, 3, 5), 2);
        public Sphere sphere3 = new Sphere(new Vector3(3, 5, 0), 3);
        public Plane plane = new Plane(3, v = Normalize(new Vector3(0, -3, 1)));      //initializing scene


        static Vector3 Normalize(Vector3 v) //generic normalization for any vector3
        {
            double div = Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
            return new Vector3((float)(v.X / div), (float)(v.Y / div), (float)(v.Z / div));
        }
    }
}
