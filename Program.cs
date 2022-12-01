namespace FindMaxGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("find max number");

            Console.WriteLine("Maximum Integer Value:" + Refactor1.findmax<int>(3, 8, 11));
            Console.WriteLine("Maximum Float Value:" + Refactor1.findmax<float>(1.11f, 3.33f, 4.44f));
            Console.WriteLine("Maximum String Value:" + Refactor1.findmax<string>("aa", "bb", "cc"));
        }
    }
}