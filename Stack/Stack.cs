using System.IO.Pipes;

namespace Stack
{
    internal class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new();
            for (int i = 0; i < 5; i++) 
            {
                stack.Push(i); // i 집어넣기
            }
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Peek()); // 가장 마지막에 넣은 데이터 확인 
                Console.WriteLine(stack.Pop()); // 가장 마지막에 넣은 데이터 꺼내기
            }
        }
    }
}
