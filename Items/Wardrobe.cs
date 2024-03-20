using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Items
{
    public class Wardrobe : Item
    {
        public Wardrobe(Point currentPosition, int sizeWidth = 4, int sizeLength = 1) : base(sizeWidth, sizeLength, currentPosition)
        {
        }

        public override string ShortName => "W";
        public override string Name => "Шкаф";
    }
}
