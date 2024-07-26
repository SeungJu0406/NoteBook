namespace List
{
    internal class List
    {
        static void Main11(string[] args)
        { 
            List<string> list = new List<string>(10)
            {
                "안","녕","하","세","요"
            };
            foreach (string item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine($"용량 {list.Capacity}");
            Console.WriteLine($"크기 {list.Count}");
            list.Add("요");
            list.Add("요");
            list.Add("요");
            list.Add("요");
            list.Add("요");
            list.Add("요");
            list.Add("요");
            Console.WriteLine($"용량{list.Capacity}");
            Console.WriteLine($"크기 {list.Count}");
        }
    }
}
