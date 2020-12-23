using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task2
{
    class TTriangle
    {
        private double a_;
        private double b_;
        private double c_;

        public TTriangle()
        {
            Random r = new Random();
            a_ = r.Next(1, 50);
            b_ = a_;
            c_ = a_;
        }

        public TTriangle(double a, double b, double c)
        {
            this.a_ = a;
            this.b_ = b;
            this.c_ = c;
        }

        public TTriangle(TTriangle copy)
        {
            a_ = copy.a_;
            b_ = copy.b_;
            c_ = copy.c_;
        }

        public double A
        {
            get { return a_; }
            set { a_ = value; }
        }

        public double B
        {
            get { return b_; }
            set { b_ = value; }
        }

        public double C
        {
            get { return c_; }
            set { c_ = value; }
        }

        override public string ToString()
        {
            return $"Sides of this triangle are {a_}, {b_} and {c_} cm";
        }

        public string Output(double a)
        {
            return a + "cm";
        }

        public double CalculatePerimeter(TTriangle triangle)
        {
            return (triangle.a_ + triangle.b_ + triangle.c_);
        }

        public double CalculateArea(TTriangle triangle)
        {
            return (Math.Sqrt(((triangle.a_ + triangle.b_ + triangle.c_) / 2) * 
                              (((triangle.a_ + triangle.b_ + triangle.c_) / 2) - triangle.a_) * 
                              (((triangle.a_ + triangle.b_ + triangle.c_) / 2) - triangle.b_) * 
                              (((triangle.a_ + triangle.b_ + triangle.c_) / 2) - triangle.c_)));
        }

        public bool Equals(TTriangle triangle, TTriangle triangle2)
        {
            if (triangle.a_ == triangle2.a_ && triangle.b_ == triangle2.b_ && triangle.c_ == triangle2.c_) return true;
            else return false;
        }
        public static TTriangle operator *(TTriangle triangle, double a)
        {
            TTriangle triangleMultiplied = new TTriangle(triangle.a_ * a, triangle.b_ * a, triangle.c_ * a);
            return triangleMultiplied;
        }
    }
}
