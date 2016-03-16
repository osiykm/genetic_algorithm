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
            Chromosome.points = new List<Coordinates>() { new Coordinates(1, 1), new Coordinates(2, 1) , new Coordinates(1, 3), new Coordinates(1, 34) };
            Random RND = new Random();
            for (int i = 0; i < Chromosome.points.Count; i++)
            {
                temp.Add(i);
            }
            temp = temp.OrderBy(v => RND.Next()).ToList();
            Chromosome temp2 = new Chromosome();
            temp2.AddRange(temp);
            population.Add(temp2);
            population[0].Resize();
            textBox1.Text = population[0].Size.ToString();
        }
    }
    }
