namespace Additional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float value = 2.4f;
            Console.WriteLine(value.Round());
            string text = "hello world dasd";
            Console.WriteLine(text.WordCount());
        }
        
    }
    public static class Extension
    {
        public static int Round(this float value) // 확장메서드
        {
            if (value % 1 >= 0.5f)
            {
                return (int)(value + 1);
            }
            else
                return (int)value;
        }
        public static int WordCount(this string text)
        {
            string result=text.Replace(" ","");
            return result.Length;
        }
    }
}
