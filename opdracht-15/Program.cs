namespace opdracht_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a double");
            double var2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give a true or false");
            Boolean var3 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("your integer: " + var1);
            Console.WriteLine("your double: " + var2);
            Console.WriteLine("your boolean: " + var3);
        }
    }
}