using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Template;

namespace template
{
    class Scene
    {
        public Camera camera;
        Surface Screen = new Surface(512, 512);
        //3 spheres, 1 plane
        Sphere sphere1 = new Sphere(new OpenTK.Vector3(0,0,5), 1);
        Sphere sphere2 = new Sphere(new OpenTK.Vector3(0, 3, 5), 2);
    }
}
