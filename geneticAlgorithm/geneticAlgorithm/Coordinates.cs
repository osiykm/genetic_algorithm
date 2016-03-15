using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geneticAlgorithm
{/// <summary>
/// Клас координат 
/// </summary>
    class Coordinates
    {
        private int x { get; }
        private int y { get; }
        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Вертає відстань між точками а і b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
       public  static double getLenght(Coordinates a, Coordinates b) 
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2)+Math.Pow(a.y-b.y, 2));
            
        }
    }
}
