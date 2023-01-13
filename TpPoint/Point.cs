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
        #region Constructor
        /// <summary>
        /// Defaut constructor
        /// </summary>
        public Point()
        {
        }
        #endregion
        #region Get & Set Abscissa
        /// <summary>
        /// Abscissa
        /// </summary>
        public int Abscissa { get => _abscissa; set => _abscissa = value; }
        #endregion
        #region Get & Set Ordered
        /// <summary>
        /// Ordered
        /// </summary>
        public int Ordered { get => _ordered; set => _ordered = value; }
        #endregion       
        #region Method
        /// <summary>
        /// Calculate square
        /// </summary>
        /// <param name="Coordonee"></param>
        /// <returns></returns>
        private double Square(double Coordonee)
        {
            return Coordonee * Coordonee;
        }
        /// <summary>
        /// The one-point standard
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public double Norme(Point point)
        {
            return Math.Sqrt(Square(0 - Abscissa) + Square(0 - Ordered));
        } 
        #endregion
    }
}
