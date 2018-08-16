using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicDotNet.Objects3D
{
    class Program
    {
        protected static IList<Object3D> objects3D = new List<Object3D>();

        protected static void InitObjects3D()
        {
            objects3D.Add(new Block(new int[] {5, 6, 5}));
            objects3D.Add(new Sphere(new int[] {23, 500 }));
            objects3D.Add(new Sphere(new int[] {20, 200 }));
            objects3D.Add(new Block(new int[] {5, 6, 50 }));
            objects3D.Add(new Sphere(new int[] {3, 50 }));
            objects3D.Add(new Block(new int[] {5, 10, 3}));
            objects3D.Add(new Block(new int[] {1, 1, 2 }));
            objects3D.Add(new Sphere(new int[] {15, 270 }));
            objects3D.Add(new Sphere(new int[] {5, 24 }));
        }

        protected static double GetTotalVolume(IList<Object3D> objects)
        {
            var totalVolume = 0.0;
            foreach(var o in objects)
            {
                totalVolume += o.GetVolume();
            }
            return totalVolume;
            //return objects.Sum(o => o.GetVolume());
        }

        protected static double GetTotalSurface(IList<Object3D> objects)
        {
            var totalSurface = 0.0;
            foreach(var o in objects)
            {
                totalSurface += o.GetSurfaceArea();
            }
            return totalSurface;
            //return objects.Sum(o => o.GetSurfaceArea());
        }

        static void Main(string[] args)
        {         
            InitObjects3D();
            Console.WriteLine($"Total 3D objects:{objects3D.Count}");
            Console.WriteLine($"Total surface area of 3D objects:{GetTotalVolume(objects3D)}");
            Console.WriteLine($"Total volume of 3D objects:{GetTotalSurface(objects3D)}");
            Console.ReadLine();
        }
    }
}
