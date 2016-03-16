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


        }
        /// <summary>
        /// Создание первой популяции
        /// </summary>
        private void GenerateFirstPopulation()
        {
            List<int> temp = new List<int>();
            Random RND = new Random();
            for (int i = 0; i < Chromosome.points.Count; i++)
            {
                temp.Add(i);
            }
            for (int i = 0; i < populationSize; i++)
            {
                temp = temp.OrderBy(v => RND.Next()).ToList();
                Chromosome temp2 = new Chromosome(); 
                temp2.AddRange(temp);
                population.Add(temp2);
                population[i].Resize();
            }
        }
    }
}
