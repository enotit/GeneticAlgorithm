using System;
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
        public List<PersonRoom> population = new List<PersonRoom>();
        public PersonRoom Min = null;
        public Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Render();
        }

        protected void Render()
        {
            
        }

        protected void GenerateRandomPopulation(int count)
        {
            population.Clear();
            for (int c = 0; c < count; c++)
            {
                var pr = new PersonRoom();
                pr.CreateRandomPopulation();
                population.Add(pr);
            }
        }
        protected float MinFunction()
        {
            float m = population[0].GetValueFitnessFunction();
            foreach (var p in population)
            {
                float v = p.GetValueFitnessFunction();
                if (m > v) 
                    m = v;
                if (v < Min.GetValueFitnessFunction())
                    Min = p;
            }
            return m;
        }

        protected List<PersonRoom> SelectParents()
        {
            population = population.OrderBy(p => p.GetValueFitnessFunction()).ToList();
            List<PersonRoom> parents = new List<PersonRoom>();

            for (int i = 0; i < population.Count / 2; i++)
            {
                parents.Add(population[i]);
            }

            for (int i = 0; i < population.Count / 2; i++)
            {
                var pr = new PersonRoom();
                pr.CreateRandomPopulation();
                parents.Add(pr);
            }

            return parents;
        }

        protected int GetRandomIndex(int count)
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

        protected void Multiplication()
        {
            var count = population.Count / 2;
            for (var index = count; index < population.Count; index++)
            {

                var a = population[GetRandomIndex(index)];
                var b = population[GetRandomIndex(index)];
                var child = new PersonRoom();
                child.Items = new List<Item>(a.Items).ToArray(); // copy
                child.Multiplication(b);
                population[index] = child;
            }
        }

        protected int Algorithm(int countChromosomes, int maxIteration)
        {
            GenerateRandomPopulation(countChromosomes);
            Min = population[0];
            string logs = GetDescriptionIteration(0);
            int iteration = 0;
            float min = MinFunction();
            List<double> history = new List<double> ();
            while (min != 0 && iteration < maxIteration)
            {
                population = SelectParents();
                Multiplication();
                min = MinFunction();

                if (history.Count > 5 && min == history.Last() && min == history[history.Count - 5])
                {
                    GenerateRandomPopulation(countChromosomes);
                    min = MinFunction();
                    history.Clear();
                    logs += $"Произошла встряска{Environment.NewLine}";
                }

                history.Add(min);

                iteration++;
                Console.Write(iteration);
                logs += GetDescriptionIteration(iteration) + $"Минимум: {min}{Environment.NewLine}";
            }

            iterationCount.Text = $"Результат за {iteration} итераций";
            minfuction.Text = $"{Min.GetInfo()} = {Min.GetValueFitnessFunction()}";
            resultMinFunction.Text = Min.GetVisualRoom();
            textBox1.Text += logs;
            return iteration;
        }

        protected string GetDescriptionIteration(int iteration)
            => $"{Environment.NewLine}Итерация: {iteration}{Environment.NewLine}{string.Join(Environment.NewLine, population.Select(p => p.GetInfo()))}{Environment.NewLine}";

        private void generation_Click(object sender, EventArgs e)
        {
            Render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(chromosoms.Text, out var temp) && temp > 3)
            {
                int count = temp;
                if (int.TryParse(maxIteration.Text, out temp))
                {
                    textBox1.Text = "";
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
