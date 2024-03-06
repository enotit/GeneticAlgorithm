using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithm.Items;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class VisualRoom // TODO: rename to Person
    {
        // TODO: create methods: createRandom, мутация, скрещивание
        public const int WIDTH = 4;
        public const int LENGTH = 7;
        public List<Item> Items = new List<Item>() // Todo: type to array
        {
            new TV(1, 1, new Point(1,2)),
            new Table(1, 2, new Point(2,2)),
            new Sofa(1, 2, new Point(4,2)),
            new FloorLamp(1, 1, new Point(4,2)),
            new Wardrobe(4, 1, new Point(1,7)),
        };
        public VisualRoom() { }

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
                            result += item.GetType().Name.Substring(0, 1);
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

    }
}