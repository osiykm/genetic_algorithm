using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geneticAlgorithm
{
    class GeneticAlgorithm
    {

        /// <summary>
        /// максимальное количество поколений
        /// </summary>
        private int maxAges;
        /// <summary>
        /// Шанс мутации
        /// </summary>
        private double mutationChance;
        /// <summary>
        /// количество особей в популяции
        /// </summary>
        private int populationSize;
        /// <summary>
        /// Тип кроссовера
        /// </summary>
        private Crossover crossoverType;
        /// <summary>
        /// Массив вариантов мутаций
        /// </summary>
        private Mutation mutation;
        /// <summary>
        /// Популяция
        /// </summary>
        private List<Chromosome> population;
        /// <summary>
        /// Инициализация генетического алгоритма
        /// </summary>
        /// <param name="maxAges">Максимальное количество поколений </param>
        /// <param name="pointArray"> Точки</param>
        /// <param name="mutationChance">Шанс мутации</param>
        /// <param name="populationSize">количество особей в популяции</param>
        /// <param name="mutation">Варианты мутации</param>
        /// <param name="crossoverType">тип кроссовера</param>
        public GeneticAlgorithm(int maxAges, List<Coordinates> pointArray, double mutationChance, int populationSize, Mutation mutation, Crossover crossoverType)
        {
            this.maxAges = maxAges;
            Chromosome.points = pointArray;
            this.mutationChance = mutationChance;
            this.populationSize = populationSize;
            this.mutation = mutation;
            this.crossoverType = crossoverType;
        }
        /// <summary>
        /// Основной метод алгоритма
        /// </summary>
        public Chromosome run()
        {
            GenerateFirstPopulation(); //создаю первую популяцию
            QuickSort(ref population); //Сортирую в порядке 
            for (int i = 1; i < maxAges; ++i)
            {
                for (int k = 0; k < populationSize; ++k)
                    population.Add(Chromosome.getCrossover(population[SelectionDuel()], population[SelectionDuel()], crossoverType));

                if (mutationChance != 0)
                    for (int mutation_i = populationSize; mutation_i < population.Count; mutation_i++)
                    {
                        if (Randoms.getDouble() <= mutationChance)
                            population[mutation_i] = Chromosome.getMutation(population[mutation_i], mutation);
                    }
                QuickSort(ref population);
                population = population.GetRange(0, populationSize);
            }
            return population[0];
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
            population = new List<Chromosome>();
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
        /// Турнирнй алгоритм
        /// </summary>
        private int SelectionDuel()
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 2; ++i)
            {
                list.Add(Randoms.getInt(populationSize));
            }
            list.Sort();
            return list[0];
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
        private static void QuickSort(ref List<Chromosome> array)
        {
            QuickSort(ref array, 0, array.Count-1);
        }
    }
}   
