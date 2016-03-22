using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geneticAlgorithm
{/// <summary>
/// Хромосома в алгоритме
/// </summary>
    class Chromosome : List<int>
    {
        /// <summary>
        /// Массив координат
        /// </summary>
       public  static List<Coordinates> points;
        /// <summary>
        /// Длина пути
        /// </summary>
        private double size;

        public Chromosome()
        {
        }

        public double Size
        {
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Обсчитывает величину пути
        /// </summary>
        public void Resize()
        {

            size = 0;
            for (int i = 0; i < this.Count; i++)
            {
                size += Coordinates.getLenght(points[this[i]], points[this[getArrayindex((i + 1),  this.Count)]]);
            }
        }
        
        public String toString()
        {
            if (this.Count == 0)
                return "";
            String s = "";
            
            for (int i = 0; i < this.Count; i++)
            {
                s += this[i] + ", ";
            }
            return s.Substring(0, s.Length-2);
        }
        
        /// <summary>
        /// Возвращает child
        /// </summary>
        /// <param name="a">родитель а</param>
        /// <param name="b">родитель b</param>
        /// <param name="crosoverType">тип кроссовера</param>
        /// <returns></returns>
        /// 
        public static Chromosome getCrossover(Chromosome a, Chromosome b, Crossover crosoverType)
        {
            switch(crosoverType)
            {
                case Crossover.MODIFIED: return CrossoverModified(a, b);
                case Crossover.CYCLE: return CrossoverCycle(a, b);
                case Crossover.ORDERED: return CrossoverOrdered(a, b);
                case Crossover.RECOMBINATION: return CrossoverRecombination(a, b);
            }
            return null;
        }
        //__Кроссоверы
        /// <summary>
        /// Упорядоченный кроссовер
        /// </summary>
        /// <param name="a">Первый родитель</param>
        /// <param name="b">Второй родитель</param>
        /// <returns></returns>
        private static Chromosome CrossoverOrdered(Chromosome a, Chromosome b)
        {
            int l = getArrayindex(Randoms.getInt(), a.Count); //создаю две точки сечения в кроссовере
            int r = getArrayindex(Randoms.getInt(), a.Count); // 
            FirsSwap(ref l, ref r); //упорядичываю их
            int childI = getArrayindex((r + 1), a.Count); 
            for (int i = childI; childI != l; i = getArrayindex((i+1),a.Count))
            {
                if(!(a.IndexOf(b[i])>=l && a.IndexOf(b[i])<=r))
                {
                    a[childI] = b[i];
                    childI= getArrayindex((childI+1),a.Count);
                }
            }
            a.Resize();
            return a;
        }
        /// <summary>
        /// Циклический кроссовер
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Chromosome CrossoverCycle(Chromosome a, Chromosome b)
        {
            List<int> temp = new List<int>();
            List<int> tempB = new List<int>();
            int rand;
            int i = 0;
            while(temp.Count < a.Count)
            {
                rand = getArrayindex(Randoms.getInt(),  a.Count());
                while (temp.IndexOf(rand) != -1)
                    rand = getArrayindex((rand + 1), a.Count);
                List<int> buf;
                if (i%2 == 0)
                    buf = CycleCrossoverStep(a, b, rand);
                else
                    buf = CycleCrossoverStep(b, a, rand);
                temp.AddRange(buf);
                if (i%2 != 0)
                  tempB.AddRange(buf);
                ++i;
            }
            foreach (var item in tempB)
            {
                a[item] = b[item];
            }
            a.Resize();
            return a;
        }

        /// <summary>
        /// Кроссовер рекомбинации ребер
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static Chromosome CrossoverRecombination(Chromosome a, Chromosome b)
        {
            Chromosome child = new Chromosome(); //создание 
            List<List<int>> buf = new List<List<int>>();
            for(int i = 0; i < a.Count; ++i)
                buf.Add(getConnected(a, b, i));
            while(buf.Count != 0)
            {
                ArraySort(ref buf);
                child.Add(buf[0][0]);
                for(int i = buf.Count-1; i > 0; i--)
                    buf[i].Remove(buf[0][0]);
                buf.RemoveAt(0);
            }
            child.Resize();
            return child;
        }

        private static Chromosome CrossoverModified(Chromosome a, Chromosome b)
        {
            Chromosome child = new Chromosome();
            int rand = getArrayindex(Randoms.getInt(), a.Count);
            child.AddRange(a.GetRange(0, rand));
            for (int i = rand; i < b.Count; ++i)
            {
                if (child.IndexOf(b[i]) == -1)
                    child.Add(b[i]);
            }
            for (int i = rand; i < a.Count; ++i)
            {
                if (child.IndexOf(a[i]) == -1)
                    child.Add(a[i]);
            }
            child.Resize();
            return child;
        }

        //_____________________Мутации
        public static Chromosome getMutation(Chromosome a, Mutation mutationType)
        {
            switch(mutationType)
            {
                case Mutation.GREED:
                    return  MutationGreed(a);
                case Mutation.INVERSION:
                    return MutationInversion(a);
                case Mutation.TRANSLOCATION:
                    return MutationTranslocation(a); 
            }
            a.Resize();
            return a;
        }
        /// <summary>
        /// Жадная мутация
        /// </summary>
        /// <param name="a">мутируемый</param>
        /// <returns></returns>
        private static Chromosome MutationGreed(Chromosome a)
        {
            Swap(ref a, getArrayindex(Randoms.getInt(), a.Count), getArrayindex(Randoms.getInt(), a.Count));
            a.Resize();
            return a;
        }

        /// <summary>
        /// Инверсная мутация
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private static Chromosome MutationInversion(Chromosome a)
        {
              int l = getArrayindex(Randoms.getInt(), a.Count);
              int r = getArrayindex(Randoms.getInt(), a.Count);
            FirsSwap(ref l,ref  r);
            int size_2 = (r - l)/2;
            for(int i = l; i < l+ size_2; ++i)
            {
                Swap(ref a,i, r-i+l);
            }
            a.Resize();
            return a;
        }

        /// <summary>
        /// Мутация Транслокации
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private static Chromosome MutationTranslocation(Chromosome a)
        {
            int l = getArrayindex(Randoms.getInt(), a.Count);
            int r = getArrayindex(Randoms.getInt(), a.Count);
            FirsSwap(ref l, ref r);
            Chromosome temp = new Chromosome();
            temp.AddRange(a.GetRange(l, r - l));
            a.RemoveRange(l, r - l);
            a.InsertRange(getArrayindex(Randoms.getInt(), a.Count), temp);
            a.Resize();
            return a;
        }

        //________________________Перегрузка операторов
        public static Boolean operator ==(Chromosome a, Chromosome b)
        {
            return a.size == b.size;
        }
        public static Boolean operator !=(Chromosome a, Chromosome b)
        {
            return a.size != b.size;
        }
        public static Boolean operator >(Chromosome a, Chromosome b)
        {
            return a.size > b.size;
        }
        public static Boolean operator <(Chromosome a, Chromosome b)
        {
            return a.size < b.size;
        }
        public static Boolean operator >=(Chromosome a, Chromosome b)
        {
            return a.size >= b.size;
        }
        public static Boolean operator <=(Chromosome a, Chromosome b)
        {
            return a.size <= b.size;
        }


        //________________________Служебные функции
        /// <summary>
        /// Если a > b то меняет их местами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void FirsSwap(ref int a, ref int b)
        {
            if(a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
        }

        /// <summary>
        /// Возвращает замкнутый путь (шаг циклического кросовера)
        /// </summary>
        /// <param name="a"> ПервыйВторой</param>
        /// <param name="b"></param>
        /// <param name="index"> Начало пути</param>
        /// <returns></returns>
        private static List<int> CycleCrossoverStep(Chromosome a, Chromosome b, int index)
        {
            List<int> indexes = new List<int>() {};
            do
            {
                indexes.Add(index);
                index = a.IndexOf(b[index]);
            } while (indexes[0] != index);
            return indexes;
        }

        /// <summary>
        /// Возвращает количество присоединений к елементу + 1, первое число в массиве cам елемент
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="key">Индекс елемента с а</param>
        /// <returns></returns>
        private static List<int> getConnected(Chromosome a, Chromosome b, int key)
        {
            List<int> temp = new List<int>();
            int number = a.IndexOf(key);
            temp.Add(a[key]);
            temp.Add(a[getArrayindex((key - 1), a.Count)]);
            temp.Add(a[getArrayindex((key + 1), a.Count)]);
            if (temp.IndexOf(b[getArrayindex(b.IndexOf(number)-1, b.Count)]) == -1)
                temp.Add(b[getArrayindex(b.IndexOf(number)-1, b.Count)]);
            if (temp.IndexOf(b[getArrayindex(b.IndexOf(number)+1, b.Count)]) == -1)
                temp.Add(b[getArrayindex(b.IndexOf(number)+1 , b.Count)]);
            return temp;
        }

        /// <summary>
        /// Возвращает индекс, после проверки на соответствие границам массива
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        private static int getArrayindex(int index, int size)
        {
            if (index < 0)
                return size + index;
            return (index) % size;
        }

        private static void ArraySort(ref List<List<int>> temp)
        {
            for (int i = 0; i < temp.Count-1; i++)
            {

                int index = i;
                for (int k = i+1; k < temp.Count; k++)
                    if (temp[index].Count > temp[k].Count)
                        index = k;
                List<int> buf = temp[i];
                temp[i] = temp[index];
                temp[index] = buf;
            }
        }

        private static void Swap(ref Chromosome a, int l, int r)
        {
            if (l != r)
            {
                a[l] = a[l] + a[r];
                a[r] = a[l] - a[r];
                a[l] = a[l] - a[r];
            }
        }
    }
}
