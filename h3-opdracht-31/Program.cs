namespace h3_opdracht_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int longestC = 0;
            int hoogsteage = 0;
            string hoogstenaam = "";
            while (true)
            {
                string input = Console.ReadLine();
                int year = 2023;
                if (input == "")
                {
                    Console.WriteLine("longest name: " + hoogstenaam);
                    Console.WriteLine("highest age: " + hoogsteage);
                    break;
                }


                string[] pieces = input.Split(",");

                int hh = Convert.ToInt32(pieces[1]);

                int h = year - hh;

                string word = pieces[0];

                int length = word.Length;
                
                
                if (h > hoogsteage)
                {
                    hoogsteage = h;
                }
                if (length > longestC)
                {
                    hoogstenaam = word;
                    longestC = length;
                }
            }
        }
    }
}