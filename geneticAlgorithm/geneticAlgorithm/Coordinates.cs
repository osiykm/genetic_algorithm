using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_genetic_algoritn
{/// <summary>
/// Клас координат 
/// </summary>
    class Coordinates
    {
        private int x { get; }
        private int y { get; }
        Coordinates(int x, int y)
        {

        }
        /// <summary>
        /// Вертає відстань між точками а і b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double getLenght(Coordinates a, Coordinates b) 
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2)+Math.Pow(a.y-b.y, 2));
            
        }
    }
}
