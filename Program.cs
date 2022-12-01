namespace FindMaxGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find the maximum number: ");
            int[] arr = { 111, 222, 333, 444, 555 };
            ExtendGeneric<int> generic = new ExtendGeneric<int>(arr);
            generic.PrintMaxValue();
            double[] doublearr = { 11.1, 22.2, 33.3, 44.4, 55.5 };
            ExtendGeneric<double> genericDouble = new ExtendGeneric<double>(doublearr);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "666", "777", "888", "999", "000" };
            ExtendGeneric<string> genericString = new ExtendGeneric<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}