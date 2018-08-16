using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.Objects3D
{
    public class Block : Object3D
    {
        protected int Width;
        protected int Length;
        protected int Height;
  
        public Block(int[] props)
        {
            Width = props[0];
            Length = props[1];
            Height = props[2];
        }
  
        public int GetWidth() { return Width; }
        public int GetLength() { return Length; }  
        public int GetHeight() { return Height; }
        public override double GetVolume() { return Width * Length * Height; }
        public override double GetSurfaceArea() { return 2.0 * Width * Length + 2.0 * Length * Height + 2.0 * Width * Height; }
        public override double GetDensity() { throw new NotImplementedException(); }
    }
}
