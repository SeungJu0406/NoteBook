using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleGate
{
    public class DelegateChain
    {
        public static void Main111()
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
    }
}
