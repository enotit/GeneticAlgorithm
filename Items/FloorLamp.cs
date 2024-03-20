using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Items
{
    public class FloorLamp : Item
    {
        public FloorLamp(Point currentPosition, int sizeWidth = 1, int sizeLength = 1) : base(sizeWidth, sizeLength, currentPosition)
        {
        }

        public override string ShortName => "FL";
        public override string Name => "Напольная лампа";

        override protected float Algorithm(Item[] items)
        {
            float f = 0;
            foreach (Item item in items)
            {
                if (item.GetType() ==  typeof(Sofa))
                {
                    f += Math.Max(0, item.CurrentPosition.DistanceTo(this.CurrentPosition) - 1);
                }
            }
            return f;
        }
    }
}
