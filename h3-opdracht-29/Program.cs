namespace h3_opdracht_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hoogste = 0; true;)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("Age of the oldest: " + hoogste);
                    break;
                }
                string[] pieces = input.Split(",");
                int h = Convert.ToInt32(pieces[1]);
                if (h > hoogste ) {
                    hoogste = int.Parse(pieces[1]);
                }
            }
        }
    }
}