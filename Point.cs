using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Point
    {
        public double X; 
        public double Y; 
        public Point(double x, double y) { 
            X = x; 
            Y = y; 
        }

        public Point() { }

        public float DistanceTo(Point itemPosition)
            => (float)Math.Sqrt(Math.Pow(X - itemPosition.X, 2) + Math.Pow(Y - itemPosition.Y, 2));

    }
}