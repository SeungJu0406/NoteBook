using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleGate
{
    public class Program1
    {
        static void Main(string[] args)
        {
            bool bigger = Compare(3, 2, Bigger); // compare에 Bigger 함수 넣어서 사용
            bool less = Compare(3, 5, Less);
            bool equal = Compare(3, 3, Equal);
            int[] array1 = { 1, 3, 5, 7, 9 };
            int less1 = CountIf(array1, 4, Less);
            Console.WriteLine(less1);
        }
        public static bool Bigger(int left, int right)
        {
            return left > right;
        }
        public static bool Less(int left, int right)
        {
            return left < right;
        }
        public static bool Equal(int left, int right)
        {
            return left == right;
        }
        public static bool Compare(int left, int right, Func<int, int, bool> comperer)
        // 델리게이트를 매개변수로 전달. comperer에 따라 결과 달라짐
        {
            return comperer(left, right);
        }
        public static int CountIf(int[] array, int value, Func<int, int, bool> comparer)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item <= value)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
