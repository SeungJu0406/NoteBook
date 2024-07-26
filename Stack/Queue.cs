using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Queue
    {
        public static void Main()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2); // 데이터 넣기 0(1)
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Dequeue(); // 데이터 꺼내기 0(1)
            queue.Dequeue();
        }
    }
}
