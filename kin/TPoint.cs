using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convexhull
{
    public class TPoint : IComparable<TPoint> {
	private double x, y;
	
	public double getX() {
		return x;
	}
	
	public double getY() {
		return y;
	}
	
	public TPoint(double x, double y){
		this.x = x;
		this.y = y;
	}
	
	public int compareTo(TPoint arg0) {
		double x2 = arg0.getX();
		return ((this.x == x2) ? this.y.CompareTo(arg0.getY()) : this.x.CompareTo(x2));
	}
}
}
