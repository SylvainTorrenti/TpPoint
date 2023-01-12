using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPoint
{
    internal class Point
    {
        private int _abscissa;
        private int _ordered;
        public int Abscissa { get => _abscissa; set => _abscissa = value; }
        public int Ordered { get => _ordered; set => _ordered = value; }
        public Point()
        {
        }
        private double Carre(double Coordonee)
        {
            return Coordonee * Coordonee;
        }
        public double Norme(Point point)
        {
            return Math.Sqrt(Carre(0 - Abscissa) + Carre(0 - Ordered));
        }
    }
}
