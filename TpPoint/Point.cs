using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPoint
{
    internal class Point
    {
        #region Attribute
        private int _abscissa;
        private int _ordered;
        #endregion
        #region Get & Set Abscissa
        public int Abscissa { get => _abscissa; set => _abscissa = value; }
        #endregion
        #region Get & Set Ordered
        public int Ordered { get => _ordered; set => _ordered = value; }
        #endregion
        #region Constructor
        public Point()
        {
        }
        #endregion
        #region Method
        private double Carre(double Coordonee)
        {
            return Coordonee * Coordonee;
        }
        public double Norme(Point point)
        {
            return Math.Sqrt(Carre(0 - Abscissa) + Carre(0 - Ordered));
        } 
        #endregion
    }
}
