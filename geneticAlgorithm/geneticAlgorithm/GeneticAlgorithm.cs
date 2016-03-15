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
        /// <summary>
        /// Инициализация генетического алгоритма
        /// </summary>
        /// <param name="maxAges">Максимальное количество поколений </param>
        /// <param name="pointArray"> Точки</param>
        /// <param name="mutationChance">Шанс мутаций</param>
        /// <param name="populationSize количество особей в популяции">количес</param>
        GeneticAlgorithm(int maxAges, List<Coordinates> pointArray, double mutationChance, int populationSize, List<Mutation> mutation)
        {
            this.maxAges = maxAges;
            this.pointArray = pointArray;
            this.mutationChance = mutationChance;
            this.populationSize = populationSize;
            this.mutation = mutation;
        }

    }
}
