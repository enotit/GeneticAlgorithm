﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        protected Random rand = new Random();
        protected int X1 = -10;
        protected int X2 = 10;
        protected int Y1 = -10;
        protected int Y2 = 10;

        public Form1()
        {
            InitializeComponent();
        }

        protected double f(double x, double y)
            => (1 - x) * (1 - x) + 100 * (y - x * x) * (y - x * x);



        private void Form1_Load(object sender, EventArgs e)
        {
            Render();
        }

        protected void Render()
        {
            string logs = "";
            logs = "\t";
            for (int x = X1; x <= X2; x++)
                logs += x + "\t";
            logs += Environment.NewLine;

            for (int y = Y1; y <= Y2; y++)
            {
                logs += y + "\t";

                for (int x = X1; x <= X2; x++)
                {
                    logs += f(x, y) + "\t";
                }
                logs += Environment.NewLine;

            }
            textBox1.Text = logs;
        }

        protected Point GetRandomSpecimen()
        {
            return new Point(rand.Next(X1, X2), rand.Next(Y1, Y2));
        }

        protected Point[] GenerateRandomPopulation(int count)
        {
            Point[] chromosomes = new Point[count];
            for (int c = 0; c < chromosomes.Length; c++)
            {
                chromosomes[c] = GetRandomSpecimen();
            }
            return chromosomes;
        }
        protected double MinFunction(Point[] chromosomes)
        {
            double m = f(chromosomes[0].X, chromosomes[0].Y);
            foreach (var c in chromosomes)
            {
                var v = f(c.X, c.Y);
                if (m > v) m = v;

                if (m == 0) break;
            }
            return m;
        }

        protected Point[] SelectParents(Point[] population)
        {
            population.OrderBy(p => f(p.X, p.Y));
            List<Point> parents = new List<Point>();

            for (int i = 0; i < population.Length / 2; i++)
            {
                parents.Add(population[i]);
            }

            for (int i = 0; i < population.Length / 2; i++)
            {
                parents.Add(new Point());
            }

            return parents.ToArray();
        }

        protected int GetIndexParent(int count)
        {
            double step = 1 / count;
            int place = rand.Next(count - 1);
            double coef = step * place;

            while (coef > rand.NextDouble() + step)
            {
                place = rand.Next(count - 1);
                coef = step * place;
            }

            return place;
        }

        protected Point[] Multiplication(Point[] chromosomes)
        {
            var count = chromosomes.Length / 2;
            for (var index = count; index < chromosomes.Length; index++)
            {

                var a = chromosomes[GetIndexParent(index)];
                var b = chromosomes[GetIndexParent(index)];
                var child = new Point((rand.NextDouble() > 0.5) ? a.X : b.X, (rand.NextDouble() > 0.5) ? a.Y : b.Y);
                chromosomes[index] = child;
            }
            return chromosomes;
        }

        protected int Algorithm(int countChromosomes, int maxIteration)
        {
            Point[] chromosomes = GenerateRandomPopulation(countChromosomes);
            string logs = "";
            int iteration = 0;
            double min = MinFunction(chromosomes);
            List<double> history = new List<double> ();
            while (min != 0 && iteration < maxIteration)
            {
                chromosomes = SelectParents(chromosomes);
                chromosomes = Multiplication(chromosomes);
                min = MinFunction(chromosomes);

                if (history.Count > 2 && min == history.Last() && min == history[history.Count - 2])
                {
                    chromosomes = GenerateRandomPopulation(countChromosomes);
                    min = MinFunction(chromosomes);
                    history.Clear();
                    logs += $"Произошла встряска{Environment.NewLine}";
                }

                history.Add(min);

                iteration++;
                logs += GetDescriptionIteration(iteration, chromosomes) + $"Минимум: {min}{Environment.NewLine}";
            }

            iterationCount.Text = $"Результат за {iteration} итераций";
            textBox1.Text += logs;
            return iteration;
        }

        protected void SaveValues()
        {
            int temp;
            if (int.TryParse(X1box.Text, out temp))
            {
                X1 = temp;
            }
            else
            {
                MessageBox.Show("ERROR value (x1-y2 only int)");
            }

            if (int.TryParse(X2box.Text, out temp))
            {
                X2 = temp;
            }
            else
            {
                MessageBox.Show("ERROR value (x1-y2 only int)");
            }

            if (int.TryParse(Y1box.Text, out temp))
            {
                Y1 = temp;
            }
            else
            {
                MessageBox.Show("ERROR value (x1-y2 only int)");
            }

            if (int.TryParse(Y2box.Text, out temp))
            {
                Y2 = temp;
            }
            else
            {
                MessageBox.Show("ERROR value (x1-y2 only int)");
            }

        }

        protected string GetDescriptionIteration(int iteration, Point[] points)
            => $"{Environment.NewLine}Итерация: {iteration}{Environment.NewLine}{string.Join(", ", points.Select(p => GetDescriptionForPoint(p)))}{Environment.NewLine}";
        protected string GetDescriptionForPoint(Point p)
            => $"f({p.X}, {p.Y}) = {f(p.X, p.Y)}";

        private void generation_Click(object sender, EventArgs e)
        {
            SaveValues();
            Render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(chromosoms.Text, out var temp) && temp > 3)
            {
                int count = temp;
                if (int.TryParse(maxIteration.Text, out temp))
                {
                    Algorithm(count, temp);
                }
                else
                {
                    MessageBox.Show("ERROR value (chromosoms only int and >3)");
                }
            }
            else
            {
                MessageBox.Show("ERROR value (chromosoms only int and >3)");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
