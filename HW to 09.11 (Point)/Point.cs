using System;
using System.Collections.Generic;
using System.Text;

namespace HW_to_09._11__Point_
{

    enum ReflectionType
    {
        X,
        Y,
        Origin
    }

    class Point
    {
        public double Xcoordinate;
        public double Ycoordinate;

        public Point(double x, double y)
        {
            Xcoordinate = x;
            Ycoordinate = y;
        }

        public Point()
        {
            Xcoordinate = 1;
            Ycoordinate = 1;
        }

        public double Distance()
        {
            var theDist = Math.Sqrt(Xcoordinate * Xcoordinate + Ycoordinate * Ycoordinate);
            return theDist;
        }

        public double Distance(Point anotherPoint)
        {
            var xOfPoint = anotherPoint.Xcoordinate;
            var yOfPoint = anotherPoint.Ycoordinate;
            var theDist = Math.Sqrt((Xcoordinate - xOfPoint) * (Xcoordinate - xOfPoint) + (Ycoordinate - yOfPoint) * (Ycoordinate - yOfPoint));
            return theDist;
        }

        public static double Distance(Point firstPoint, Point secPoint)
        {
            var x1 = firstPoint.Xcoordinate;
            var y1 = firstPoint.Ycoordinate;
            var x2 = secPoint.Xcoordinate;
            var y2 = secPoint.Ycoordinate;

            var distRes = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
            return distRes;
        }

        public override string ToString()
        {
            string res;
            res = "(" + Xcoordinate.ToString() + ";" + Ycoordinate.ToString() + ")";
            return res; 
        }

        public Point Reflect(ReflectionType reflType)
        {
            Point res;
            switch(reflType)
            {
                case ReflectionType.X:
                    {
                        res = new Point(Xcoordinate, Ycoordinate * (-1));
                        break;
                    }
                case ReflectionType.Y:
                    {
                        res = new Point(Xcoordinate * (-1), Ycoordinate);
                        break;
                    }
                case ReflectionType.Origin:
                    {
                        res = new Point(Xcoordinate * (-1), Ycoordinate * (-1));
                        break;
                    }
                default:
                    {
                        res = new Point();
                        break;
                    }
            }

            return res;
        }

    }
}
