using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Items
{
    public class TV : Item
    {
        public TV(Point currentPosition, int sizeWidth=1, int sizeLength=1) : base(sizeWidth, sizeLength, currentPosition)
        {
        }

        public override string ShortName => "TV";
        public override string Name => "Телевизор";

        override protected float Algorithm(Item[] items)
        {
            float f = 0;
            foreach (Item item in items)
            {
                if (item.GetType() == typeof(Sofa))
                {
                    float d = item.CurrentPosition.DistanceTo(this.CurrentPosition);
                    f += Math.Max(0, d < 2 || d > 7? item.SizeWidth + item.SizeLength : 0);
                }
            }
            return f;
        }
    }
}
