using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GeneticAlgorithm
{
    public abstract class Item
    {
        abstract public string Name { get;}
        abstract public string ShortName { get;}

        public int SizeWidth;
        public int SizeLength;
        public Point CurrentPosition;
        private float CachedWeight = -1f;

        public Item(int sizeWidth, int sizeLength, Point currentPosition)
        {
            SizeWidth = sizeWidth;
            SizeLength = sizeLength;
            CurrentPosition = currentPosition;
        }

        public float GetWeight(Item[] items)
        {
            if (CachedWeight == -1f) 
            {
                CachedWeight = Algorithm(items);
                foreach (Item item in items)
                {
                    if (item != this) { 
                        CachedWeight += IsCollision(item) ? SizeWidth + SizeLength : 0;
                    }
                }
            }
            return CachedWeight;
        }

        public void Refresh() { CachedWeight = -1; }

        // @override
        virtual protected float Algorithm(Item[] items) {
            return 0;
        }

        public bool IsCollision(Item item)
        => CurrentPosition.X < item.CurrentPosition.X + item.SizeLength && CurrentPosition.X + SizeLength > item.CurrentPosition.X &&
            CurrentPosition.Y < item.CurrentPosition.Y + item.SizeWidth && CurrentPosition.Y + SizeWidth > item.CurrentPosition.Y;
    }
}