using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleGate
{
    public class Event
    {
        public static void Main()
        {
            Action action;
            action = AAA;
            action += BBB;
            action += CCC;
            action(); // 출력: ABC
        }
        public static void AAA()
        {
            Console.Write("A");
        }
        public static void BBB()
        {
            Console.Write("B");
        }
        public static void CCC()
        {
            Console.Write("C");
        }
        public class Player
        {
            private void Die()
            {
                // 나 주거따!!
                // >>
                // 음악실행
                // 게임오버 UI
                // 등등 효과
            }
        }
    }
}
