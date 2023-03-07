namespace opdracht_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool anwser = false;
            while (anwser == false)
            {
                Console.WriteLine("Give a number: ");
                int incomming = Convert.ToInt32(Console.ReadLine());
                if (incomming == 42)
                {
                    anwser = true;
                }
            }
        }
    }
}