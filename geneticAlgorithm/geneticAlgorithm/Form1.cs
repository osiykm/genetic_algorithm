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
            List<Coordinates> list = new List<Coordinates>() { new Coordinates(0, 0) , new Coordinates(0, 20) , new Coordinates(20, 0) , new Coordinates(20, 20) , new Coordinates(10, 100) , new Coordinates(102, 100), new Coordinates(122, 100), new Coordinates(10, 1230) };
            List<Mutation> mut = new List<Mutation> {Mutation.GREED };
            GeneticAlgorithm al = new GeneticAlgorithm(100, list, 0.001, 100, mut, Crossover.MODIFIED);
            Chromosome a = al.run();
            String s = a.Size.ToString() + " " + a.toString() + "\n";
            label1.Text += s;
            if(label1.Text.Length > s.Length*4)
            label1.Text = label1.Text.Substring(label1.Text.Length-s.Length*2);

        }
    }
    }
