using System;

namespace hh.shapeLib {
    public abstract class Shape {
        public abstract double Square();
    }

    public class Circle : Shape {
        public double Radius { get; private set; }

        public Circle(double Radius) {
            this.Radius = Radius;
        }

        public override double Square() {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
    public class Triangle : Shape {
        public double x {  get; private set; }
        public double y { get; private set; }
        public double z { get; private set; }

        public Triangle(double x, double y, double z) {
            if (x < 0 || y < 0 || z < 0) 
                throw new ArgumentException($"Error: Invalid inputs");   
            else if (x > (y + z) || y > (x + z) || z > (x + y)) 
                throw new ArgumentException($"Error: Invalid inputs");
            else {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }
        public bool IsRight() {
            return (x == Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2))
                    || y == Math.Sqrt(Math.Pow(x, 2) + Math.Pow(z, 2))
                    || z == Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
        }

        public override double Square() {
            double p = (x + y + z) / 2;
            return Math.Round(Math.Sqrt(p * (p - x) * (p - y) * (p - z)), 2);
        }
    }
}
