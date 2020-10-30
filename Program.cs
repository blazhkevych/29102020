using System;
namespace _29102020
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"({X};{Y})";
        }
        public static Point operator -(Point point)
        {
            return new Point { X = -point.X, Y = -point.Y };
        }
        public static Point operator +(Point point)
        {
            return new Point { X = point.X, Y = point.Y };
        }
        public static Point operator ++(Point point)
        {
            return new Point { X = point.X + 1, Y = point.Y + 1 };
        }
        public static Point operator --(Point point)
        {
            return new Point { X = point.X - 1, Y = point.Y - 1 };
        }
        public static Point operator +(Point point, Point point2)
        {
            return new Point { X = point.X + point2.X, Y = point.Y + point2.Y };
        }
        public static Point operator +(int n, Point point2)
        {
            return new Point { X = n + point2.X, Y = n + point2.Y };
        }
        public static Point operator +(Point point2, int n)
        {
            return n + point2;
        }
        public static bool operator ==(Point point1, Point point2)// цей оператор має бути в парі
        {
            return point1.X == point2.X && point1.Y == point2.Y;
        }
        public static bool operator !=(Point point1, Point point2)
        {
            return !(point1 == point2);
        }
        public static bool operator >(Point point1, Point point2)// цей оператор має бути в парі
        {
            return point1.X > point2.X && point1.Y > point2.Y;
        }
        public static bool operator <(Point point1, Point point2)
        {
            return point1.X < point2.X && point1.Y < point2.Y;
        }

        public override bool Equals(object obj)
        {
            //if (obj.GetType() != this.GetType())
            //  return false;

            //if (obj is Point point) //is перевіряє чи obj є типом Point
            //    return X == point.X && Y == point.Y;
            //return false;
            Point point = obj as Point; //as спроба привести obj до типу Point якщо ні верне null 
            return point != null && X == point.X && Y == point.Y;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator true(Point p)// цей оператор має бути в парі
        {
            return p.X != 0 && p.Y != 0;
        }
        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0;
        }
        public static bool operator &(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }
        public static bool operator |(Point p1, Point p2)
        {
            return p1.X == p2.X || p1.Y == p2.Y;
        }

    }
    struct spoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void testUnarni()
        {
            Point t1 = new Point { X = 10, Y = 20 };
            Console.WriteLine(t1);
            Point t2 = new Point { X = 50, Y = 100 };
            Console.WriteLine(t2);
            Point tt = -t1;
            Console.WriteLine(tt);
            tt = +t1;
            tt++;
            Console.WriteLine(tt);
            t2++;
            Console.WriteLine(t2);

            Console.WriteLine(++tt);
        }
        static void testBinarni()
        {
            Point t1 = new Point { X = 10, Y = 20 };
            Console.WriteLine(t1);
            Point t2 = new Point { X = 50, Y = 100 };
            Console.WriteLine(t2);
            Point tt = t1 + t2;
            Console.WriteLine(tt);
            tt = 100 + t1;
            Console.WriteLine(tt);
            tt = t2 + 100;
            Console.WriteLine(tt);



        }
        static void testEquals()
        {
            Point t1 = new Point { X = 10, Y = 20 };
            Console.WriteLine(t1);
            Point t2 = new Point { X = 10, Y = 20 };
            Console.WriteLine(t2);
            Point t = t1;
            Console.WriteLine(t == t1);
            Console.WriteLine(t1 == t2);
            Console.WriteLine(ReferenceEquals(t, t1));
            Console.WriteLine(ReferenceEquals(t1, t2));
            Console.WriteLine(Equals(t, t1));
            Console.WriteLine(Equals(t1, t2));
        }
        static void testEquals2()
        {
            spoint t1 = new spoint { X = 10, Y = 20 };
            Console.WriteLine(t1);
            spoint t2 = new spoint { X = 10, Y = 20 };
            Console.WriteLine(t2);
            spoint t = t1;
            //Console.WriteLine(t == t1);
            //Console.WriteLine(t1 == t2);
            Console.WriteLine(ReferenceEquals(t, t1));
            Console.WriteLine(ReferenceEquals(t1, t2));// порівнює ссилкі
            Console.WriteLine(Equals(t, t1));          // порівнює value
            Console.WriteLine(Equals(t1, t2));
            Console.WriteLine(t1.Equals(50));          // визиваємо метод від t1
            Console.WriteLine(t1.GetHashCode());
            Console.WriteLine(t2.GetHashCode());

            if (t1)
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        static void Main(string[] args)
        {
            //testUnarni();
            //testBinarni();
            //testEquals();
            testEquals2();
        }
    }
}

