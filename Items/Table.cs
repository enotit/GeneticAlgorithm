using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Items
{
    public class Table : Item
    {
        public Table(Point currentPosition, int sizeWidth = 1, int sizeLength = 2) : base(sizeWidth, sizeLength, currentPosition)
        {
        }

        public override string ShortName => "T";
        public override string Name => "Стол";

        override protected float Algorithm(Item[] items)
        {
            float f = 0;
            foreach (Item item in items)
            {
                if (item.GetType() == typeof(TV))
                {
                    f += Math.Max(0, item.CurrentPosition.DistanceTo(this.CurrentPosition));
                }
            }
            return f;
        }
    }
}
