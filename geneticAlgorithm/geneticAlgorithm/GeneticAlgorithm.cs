using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geneticAlgorithm
{

    class GeneticAlgorithm
    {

        private int maxAges;
        private double mutationChance;
        private int populationSize;
        private List<Mutation> mutation;
        private List<Chromosome> population;
        /// <summary>
        /// Инициализация генетического алгоритма
        /// </summary>
        /// <param name="maxAges">Максимальное количество поколений </param>
        /// <param name="pointArray"> Точки</param>
        /// <param name="mutationChance">Шанс мутации</param>
        /// <param name="populationSize количество особей в популяции">количес</param>
        public GeneticAlgorithm(int maxAges, List<Coordinates> pointArray, double mutationChance, int populationSize, List<Mutation> mutation)
        {
            this.maxAges = maxAges;
            Chromosome.points = pointArray;
            this.mutationChance = mutationChance;
            this.populationSize = populationSize;
            this.mutation = mutation;
        }
        /// <summary>
        /// Основной метод алгоритма
        /// </summary>
        public void run()
        {
            GenerateFirstPopulation(); //создаю первую популяцию
            QuickSort(ref population); //Сортирую в порядке 



        }
        /// <summary>
        /// Создание первой популяции
        /// </summary>
        private void GenerateFirstPopulation()
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < Chromosome.points.Count; i++)
            {
                temp.Add(i);
            }
            for (int i = 0; i < populationSize; i++)
            {
                temp = temp.OrderBy(v => Randoms.getInt()).ToList();
                Chromosome temp2 = new Chromosome(); 
                temp2.AddRange(temp);
                population.Add(temp2);
                population[i].Resize();
            }
        }
        /// <summary>
        /// Функция сортировки
        /// </summary>
        /// <param name="array">массив для сортировки</param>
        private static void QuickSort(ref List<Chromosome> array, int l, int r) 
        {
            int L = l;
            int R = r;

            if(l < r)
            {
                Chromosome mid = array[(l + r) / 2];
                while(L<=R)
                {
                    while ((L < r) && (array[L] < mid)) L++;

                    while ((R > l) && (array[R] > mid)) --R;

                    if (L <= R)
                    {
                        Chromosome T;
                        T = array[L];
                        array[L] = array[R];
                        array[R] = T;

                        ++L;
                        --R;
                    }
                }

                if (l < R) QuickSort(ref array, l, R);
                if (L < r) QuickSort(ref array, L, r);
            }

        }
        /// <summary>
        /// Функция для сортировки (Основная)
        /// </summary>
        /// <param name="array"></param>
        public static void QuickSort(ref List<Chromosome> array)
        {
            QuickSort(ref array, 0, array.Count-1);
        }
    }
}
