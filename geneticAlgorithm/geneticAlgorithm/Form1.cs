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
            Chromosome a = new Chromosome() ;
            Chromosome b = new Chromosome() ;
            for (int i = 0; i < 10; i++)
            {
                a.Add(i);
                b.Add(9 - i);
            }
            label1.Text = a.toString()+"\n" + b.toString() + "\n" + Chromosome.OrderedCrossover(a, b).toString();
        }
    }
    }
