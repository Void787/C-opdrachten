namespace h4_opdracht_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                string strink = Console.ReadLine();
                if (strink == "end")
                {
                    Console.WriteLine("end");
                    break;
                }
                else
                {
                    int number2 = Convert.ToInt32(strink);
                    number = number2 * number2 * number2;
                    Console.WriteLine(number);
                }
            }
            
        }
    }
}