using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convexhull
{
    public class AreaPolygon
    {
        public static double computeArea(TPoint[] points)
        {
            int len = points.Length, x = 0;
            TPoint[] det = new TPoint[len];
            double area = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                det[x] = points[i];
                x++;
            }
            for(int i = 0; i < len - 1; i++)
                area += (det[i].getX() * det[i + 1].getY());
            area += (det[len - 1].getX() * det[0].getY());
            for (int i = 0; i < len - 1; i++)
                area -= (det[i].getY() * det[i + 1].getX());
            area -= (det[len - 1].getY() * det[0].getX());

            return area /= 2;

        }
    }
}
