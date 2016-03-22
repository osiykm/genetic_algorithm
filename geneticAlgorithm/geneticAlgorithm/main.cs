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
    public partial class main : Form
    {
        GeneticAlgorithm ga;
        List<Coordinates> points= new List<Coordinates>();
        Graphics g;
        Pen brush = new Pen(new SolidBrush(Color.Black), 2f);
        public main()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.WhiteSmoke);
            run();
        }  

        private void run()
        {
            drawPoints();
            ga = new GeneticAlgorithm(Int32.Parse(maxAges.Text), points, Double.Parse(mutationChance.Text)/100.0, Int32.Parse(populationSize.Text), (Mutation)mutationBox.SelectedIndex, (Crossover)crossoverBox.SelectedIndex);
            Chromosome a = ga.run();
            for (int i = 0; i < a.Count; i++)
            {
                g.DrawLine(Pens.Red, points[a[i]].X, points[a[i]].Y, points[a[(i+1)%a.Count]].X, points[a[(i+1)%a.Count]].Y);
            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            g.DrawEllipse(brush, e.X - 1, e.Y - 1, 2, 2);
            points.Add(new Coordinates(e.X, e.Y));

        }

        private void generationPoints_Click(object sender, EventArgs e)
        {
            g.Clear(Color.WhiteSmoke);
            points = new List<Coordinates>();
            for (int i = 0; i < pointsCount.Value; i++)
            {
                int x = Randoms.getInt(529);
                int y = Randoms.getInt(394);
                points.Add(new Coordinates(x,y));
            }
            drawPoints();
        }

        private void drawPoints()
        {
            for (int i = 0; i < points.Count; i++)
            {
                g.DrawEllipse(brush, points[i].X-1, points[i].Y-1, 2, 2);
            }
        }
    }
    }
