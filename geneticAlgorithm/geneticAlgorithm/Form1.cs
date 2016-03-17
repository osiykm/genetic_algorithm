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
            Chromosome a = new Chromosome() { 1, 4, 8, 6, 3, 2, 7, 5};
            Chromosome b = new Chromosome() { 1, 7, 5, 4, 2, 3, 6, 8};
            label1.Text = a.toString()+"\n" + b.toString() + "\n" + Chromosome.CycleCrossover(a, b).toString();
        }
    }
    }
