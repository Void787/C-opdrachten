namespace h3_opdracht_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoogsteage = 0;
            string hoogstenaam;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("Name of the oldest: " + hoogsteage);
                    break;
                }
                string[] pieces = input.Split(",");
                int h = Convert.ToInt32(pieces[1]);
                if (h > hoogsteage)
                {
                    hoogsteage = int.Parse(pieces[1]);
                    hoogstenaam = Convert.ToString(pieces[0]);
                }
            }
        }
    }
}