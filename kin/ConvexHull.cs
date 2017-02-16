using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convexhull
{
    public class ConvexHull
    {
        public static TPoint[] compute(TPoint[] points)
        {
            int n = points.Length;
            Array.Sort(points);
            if (n < 3) return points;
            Hull upper = new Hull(points[0], points[1]);
            for (int i = 2; i < n; i++)
            {
                upper.add(points[i]);
                while (upper.hasThree() && upper.areLastThreeNonRight()) upper.removeMiddleofLastThree();
            }
            Hull lower = new Hull(points[n - 1], points[n - 2]);
            for (int i = n - 3; i >= 0; i--)
            {
                lower.add(points[i]);
                while (lower.hasThree() && lower.areLastThreeNonRight()) lower.removeMiddleofLastThree();
            }
            TPoint[] hull = new TPoint[upper.size() + lower.size() - 2];
            System.Array.Copy(upper.getTPoints(), 0, hull, 0, upper.size());
            System.Array.Copy(lower.getTPoints(), 1, hull, upper.size(), lower.size() - 2);
            return hull;
        }
    }
}