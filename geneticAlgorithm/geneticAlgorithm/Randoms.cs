﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geneticAlgorithm
{
    /// <summary>
    /// Клас для рандомных данных
    /// </summary>
    class Randoms
    {
        private static Random RND = new Random();
        public static int getInt()
        {
            return RND.Next();
        }
    }
}
