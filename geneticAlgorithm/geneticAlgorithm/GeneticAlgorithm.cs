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
        private List<Coordinates> pointArray;
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
            this.pointArray = pointArray;
            this.mutationChance = mutationChance;
            this.populationSize = populationSize;
            this.mutation = mutation;
        }

        public void run()
        {
            for (int i = 0; i < populationSize; i++)
            {

            }
        }
    }
}
