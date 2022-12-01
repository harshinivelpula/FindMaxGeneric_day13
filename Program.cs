namespace FindMaxGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("find max number");

            //Console.WriteLine("Maximum Integer Value:" + Refactor1.findmax<int>(3, 8, 11));
            //Console.WriteLine("Maximum Float Value:" + Refactor1.findmax<float>(1.11f, 3.33f, 4.44f));
            //Console.WriteLine("Maximum String Value:" + Refactor1.findmax<string>("aa", "bb", "cc"));

            Console.WriteLine("Maximum Integer Is:" + Refactor2<int>.findmax(33, 40, 8));
            Console.WriteLine("Maximum Float Is:" + Refactor2<float>.findmax(3.3f, 4.0f, 8.0f));
            Console.WriteLine("Maximum String Is:" + Refactor2<string>.findmax("aaa", "bbb", "ccc"));
        }
    }
}