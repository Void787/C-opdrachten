namespace h4_opdracht_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = 0;
            while (true)
            {
                string strink = Console.ReadLine();
                if (strink == "end")
                {
                    break;
                } else
                {
                    times++;
                }
            }
            Console.WriteLine(times);
        }
    }
}