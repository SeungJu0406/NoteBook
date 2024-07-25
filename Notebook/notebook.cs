namespace DeleGate
{
    public class Program
    {
        public static void Main()
        {
            Mydel1 delegate1 = Add;
            Console.WriteLine(delegate1(1,2));
            Mydel2 delegate2 = Message;
            delegate2("Hi");
        }
        public delegate int Mydel1(int a, int b);
        public delegate void Mydel2(string text);
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static void Message(string text)
        {
            Console.WriteLine(text);
        }

    }
}
