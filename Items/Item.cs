using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Item
    {
        public int SizeWidth;
        public int SizeLength;
        public Point CurrentPosition;

        public Item(int sizeWidth, int sizeLength, Point currentPosition)
        {
            SizeWidth = sizeWidth;
            SizeLength = sizeLength;
            CurrentPosition = currentPosition;
        }

        // OVERRIDE!
        public float getWeight(List<Item> items) {
            float result = 0;

            foreach (Item item in items)
            {
                if (item.GetType().Name == this.GetType().Name)
                {
                    result += CurrentPosition.DistanceTo(item.CurrentPosition);
                }
            }

            return result;
        }

        
    }
}