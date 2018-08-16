using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.Objects3D
{
    public class Sphere : Object3D
    {
        protected int Radius;
        protected int Mass;
  
        public Sphere(int []props)
        {
            Radius = props[0];
            Mass = props[1];
        }
  
        public int GetRadius() { return Radius; }
        public int GetMass() { return Mass; }  
        public override double GetVolume() { return Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(Radius,3), 5); }
        public override double GetSurfaceArea() { return Math.Round(4.0 * Math.PI * Math.Pow(Radius, 2.0), 5); }
        public override double GetDensity() { return Math.Round(Mass / GetVolume(), 5);} 
    }
}
