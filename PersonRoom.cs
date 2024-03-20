using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithm.Items;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class PersonRoom
    {
        public static Random rand = new Random();
        // TODO: create methods: createRandom, мутация, скрещивание
        public const int WIDTH = 4;
        public const int LENGTH = 7;
        public Item[] Items = new Item[] // Todo: type to array
        {
            new TV(new Point(1,2)),
            new Table(new Point(2,2)),
            new Sofa(new Point(4,2)),
            new FloorLamp(new Point(4, 2)),
            new Wardrobe(new Point(1, 7)),
        };

        public void CreateRandomPopulation()
        {
            foreach (var i in Items)
            {
                i.CurrentPosition = new Point(rand.Next(1, WIDTH - i.SizeWidth + 1), rand.Next(1, LENGTH - i.SizeLength + 1));
            }
        }
        
        public float GetValueFitnessFunction()
        {
            float res = 0;
            foreach (var item in Items)
            {
                res += item.GetWeight(Items);
            }
            return res;
        }

        public void Multiplication(PersonRoom partner)
        {
            int i = 0;
            foreach (var pr in partner.Items) { 
                pr.CurrentPosition = rand.NextDouble() > 0.5 ? partner.Items[i].CurrentPosition : Items[i].CurrentPosition;
                pr.Refresh();
                i += 1;
            }
        }


        public PersonRoom() { }

        public string GetVisualRoom()
        {
            string result = "";
            for (int y = 1; y < LENGTH + 1; y++)
            {
                for (int x = 1; x < WIDTH + 1; x++)
                {
                    bool flag = true;
                    foreach (Item item in Items)
                    {
                        
                        if (item.CurrentPosition.X <= x && item.CurrentPosition.X + item.SizeWidth - 1 >= x
                        && item.CurrentPosition.Y <= y && item.CurrentPosition.Y + item.SizeLength - 1 >= y)
                        {
                            result += item.ShortName;
                            flag = false;
                            break;
                        }
                    }
                    result += $"{(flag ? " " : "")}\t";
                }
                result += "\n";
            }
                
            return result;
        }

        public string GetInfo()
            => $"В комнате: {string.Join(", ", Items.ToList().Select(i=> $"\n{i.Name} X:{i.CurrentPosition.X} Y:{i.CurrentPosition.Y}"))}";


    }
}