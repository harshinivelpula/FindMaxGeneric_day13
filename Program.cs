namespace FindMaxGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maximum Integer Number is: ");
            int output = ExtendMax.MaximumIntegerNumber(8, 11, 28, 6);
            Console.WriteLine(output);
            Console.WriteLine("Maximum Float Number is:");
            float outputs = ExtendMax.MaximumFloatNumber(33.33f, 40.40f, 80.28f, 11.60f);
            Console.WriteLine(output);
            Console.WriteLine("Maximum String value is : ");
            string strigoutput = ExtendMax.MaximumStringNumber("Apple", "Peach", "Banana", "Grapes");
            Console.WriteLine(strigoutput);
        }
    }
}