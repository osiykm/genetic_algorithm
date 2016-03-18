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
            Chromosome a = new Chromosome() { 1, 2, 5, 4, 3, 6};
            Chromosome b = new Chromosome() { 3, 5, 4, 2, 1, 6};
            label1.Text = a.toString() + "\n" + b.toString() + "\n" + Chromosome.MutationTranslocation(a).toString();
            
        }
    }
    }
