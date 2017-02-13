using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace convexhull
{
    public class Hull 
    {
        List<TPoint> point = new List<TPoint>();
        public Hull(TPoint one, TPoint two)
        {
            point.Add(one);
            point.Add(two);
        }

        public void add(TPoint p)
        {
            point.Add(p);
        }

        public Boolean removeMiddleofLastThree()
        {
            if (!this.hasThree()) return false;
            int pos = point.Count;
            point.RemoveAt(pos - 2);
            return true;
        }

        public Boolean hasThree()
        {
            return point.Count > 2;
        }

        public Boolean areLastThreeNonRight()
        {
            if (!this.hasThree()) return false;

            double x1, y1, x2, y2, x3, y3;
            int pos = point.Count - 3;

            x1 = point[pos].getX();
            y1 = point[pos].getY();
            x2 = point[pos + 1].getX();
            y2 = point[pos + 1].getY();
            x3 = point[pos + 2].getX();
            y3 = point[pos + 2].getY();
            double val1 = (x2 - x1) * (y3 - y1);
            double val2 = (y2 - y1) * (x3 - x1);
            double diff = val1.CompareTo(val2);

            if (diff >= 0) return true;
            return false;
        }

        public int size()
        {
            return point.Count;
        }

        public TPoint[] getTPoints()
        {
            return point.ToArray();
        }

        public IEnumerable<TPoint> points()
        {
            return point.AsEnumerable<TPoint>();
        }
    }
}
