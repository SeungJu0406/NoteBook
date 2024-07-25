namespace Additional
{
    public class Operatoroverloading
    {
        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Point operator +(Point a, Point b)
            {
                return new Point(a.x + b.x, a.y + b.y); // x끼리 더하고 y끼리 더하는 새로운 오퍼레이터 생성
            }
        }
        public static void Main()
        {
            Point p1 = new Point(1,2);
            Point p2 = new Point(2,3);
            Point sum = p1 + p2;
            //(1,2)+(2,3)==(3,5)
            Console.WriteLine(sum.x);
            Console.WriteLine(sum.y);
        }
    }
}
