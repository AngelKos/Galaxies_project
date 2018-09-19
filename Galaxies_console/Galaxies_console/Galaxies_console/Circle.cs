using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxies_console
{
    public class Circle
    {
        protected double x, y, z;
        static protected int radius;
        protected bool movement;
        protected int next_index;
        protected bool used;
        static protected int magnification;
        protected bool draw_line;
        protected string objid;
        public bool Draw_Line { get { return draw_line; } set { draw_line = value; } }
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }
        public string Objid { get { return objid; } set { objid = value; } }
        static public int Magnification { get { return magnification; } set { magnification = value; } }
        static public int Radius { get { return radius; } set { radius = value; } }
        public bool Movement { get { return movement; } set { movement = value; } }
        public int Next_index { get { return next_index; } set { next_index = value; } }
        public bool Used { get { return used; } set { used = value; } }
        protected int number_of_cluster;
        public int Number_of_cluster { get { return number_of_cluster; } set { number_of_cluster = value; } }
        protected double mass;
        public double Mass { get { return mass; } set { mass = value; } }
        protected double ra, dec, redshift;
        public double Ra { get { return ra; } set { ra = value; } }
        public double Dec { get { return dec; } set { dec = value; } }
        public double Redshift { get { return redshift; } set { redshift = value; } }

        public Circle(double ra, double dec, double redshift)
        {
            movement = false;
            next_index = -1;
            used = false;
            number_of_cluster = -1;
            this.ra = ra;
            this.dec = dec;
            this.redshift = redshift;
        }
        public bool Pointing(int X_mouse, int Y_mouse)
        {
            return (Math.Pow(X_mouse - x * magnification, 2) + Math.Pow(Y_mouse - y * magnification, 2) <= Math.Pow(radius, 2));
        }
    }

    class Point3D
    {
        public int x, y, z;
        public double phi, r, r1, alpha;
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.r = Math.Sqrt((double)x * x + y * y);
            this.r1 = Math.Sqrt((double)y * y + z * z);
            this.phi = Math.Atan2(y, x);
            this.alpha = Math.Atan2(y, z);
        }
    }

}
