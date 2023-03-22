namespace h4_opdracht_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\rshbu\\source\\repos\\C-opdrachten\\h4-opdracht-24\\data.txt");

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}