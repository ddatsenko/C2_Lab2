using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task2
{
    class TTrianglePrizm : TTriangle
    {
        private readonly double a_;
        private double b_;
        private double c_;
        private double h_;

        public TTrianglePrizm()
        {
            Random ran = new Random();
            h_ = ran.Next(1, 50);
        }

        public TTrianglePrizm(double a, double b, double с, double h) : base(a, b, с)
        {
            a_ = a;
            b_ = b;
            c_ = с;
            h_ = h;
        }

        public TTrianglePrizm(TTrianglePrizm copy)
        {
            a_ = copy.a_;
            b_ = copy.b_;
            c_ = copy.c_;
            h_ = copy.h_;
        }

        override public string ToString()
        {
            return $"Sides of the prizm base are {a_}, {b_} and {c_}, the height of the prizm is {h_}";
        }

        public double CalculateVolume(TTrianglePrizm prizm)
        {
            return (Math.Sqrt(((prizm.a_ + prizm.b_ + prizm.c_) / 2) *
                                (((prizm.a_ + prizm.b_ + prizm.c_) / 2) - prizm.a_) *
                                (((prizm.a_ + prizm.b_ + prizm.c_) / 2) - prizm.b_) *
                                (((prizm.a_ + prizm.b_ + prizm.c_) / 2) - prizm.c_))) *
                                h_;
        }
    }
}
