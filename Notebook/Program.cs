namespace Notebook
{
    public class Program
    {
        static void Main1(string[] args)
        {
            int a = 10; // 정수형에 정수를 저장하듯
            int b = 2;
            // 델리게이트 자료형에 함수를 저장
            Func<float, float, float> dele1 = Plus;
            Console.WriteLine(dele1(a,b));
            //Action<string>
        }
        public delegate float FloatDel(float left, float right);
        public delegate void StrDel(string str);
        public static float Plus(float left, float right)
        {
            return left + right;
        }
        public static void Message(string text)
        {
            Console.WriteLine(text);
        }
        public static void GenericDel() 
        {
            Func<float, double/*여기까진 매개변수*/, int/*마지막이 반환형*/> func1 = Function;

            Action<int, float> action1 = Action; // 반환형이 없는경우는 Action 사용
        }
        public static int Function(float a, double b) { return 0; }
        public static void Action(int a, float b) { }









    }
}

