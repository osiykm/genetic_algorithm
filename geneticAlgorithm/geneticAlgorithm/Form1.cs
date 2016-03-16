using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geneticAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void textBox1_Click(object sender, EventArgs e)
        {
            List<Chromosome> population  = new List<Chromosome>();
            List<int> temp = new List<int>();
            Chromosome.points = new List<Coordinates>() { new Coordinates(1, 1), new Coordinates(2, 1) , new Coordinates(1, 3), new Coordinates(1, 34), new Coordinates(24, 34), new Coordinates(12, 34) };
            Random RND = new Random();
            for (int i = 0; i < Chromosome.points.Count; i++)
            {
                temp.Add(i);
            }
            label1.Text = "";
            for (int i = 0; i < Chromosome.points.Count; i++)
            {
                temp = temp.OrderBy(v => RND.Next()).ToList();
                Chromosome temp2 = new Chromosome();
                temp2.AddRange(temp);
                population.Add(temp2);
                population[i].Resize();
                label1.Text += population[i].Size + "\n";
            }
            label1.Text += "__________________\n";
            GeneticAlgorithm.QuickSort(ref population);
            for (int i = 0; i < Chromosome.points.Count; i++)
            {
                label1.Text += population[i].Size+"\n";
            }
        }
    }
    }
