using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Items
{
    public class Sofa : Item
    {
        public Sofa(Point currentPosition, int sizeWidth = 1, int sizeLength = 2) : base(sizeWidth, sizeLength, currentPosition)
        {
        }

        public override string ShortName => "S";
        public override string Name => "Диван";

        override protected float Algorithm(Item[] items)
        {
            float f = 0;
            foreach (Item item in items)
            {
                if (item.GetType() == typeof(Wardrobe))
                {
                    f += Math.Max(0, item.CurrentPosition.DistanceTo(this.CurrentPosition) < 2 ? item.SizeWidth + item.SizeLength : 0);
                }
            }
            return f;
        }
    }
}
