namespace opdracht_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            // setup for story
            Console.WriteLine("I will tell you a story, but I need some information.");
            Console.WriteLine("give the name of the protagonist:");
            string protagonist = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string profession = Console.ReadLine();

            // the story is told with the variables from the setup

            Console.WriteLine("the story goes as follows:");
            Console.WriteLine("\n");
            Console.WriteLine("On a Monday morning on their way to school.");
            Console.WriteLine("Steve (the best friend of " + protagonist + ") 'hey keep up you slowpoke,");
            Console.WriteLine("we're going to be late at this rate!'");
            Console.WriteLine("----");
            Console.WriteLine(protagonist + " 'Alright alright I'm coming.'");
            Console.WriteLine("----");
            Console.WriteLine("Steve 'So when are you going to tell me what's going on in that head of yours?'");
            Console.WriteLine("----");
            Console.WriteLine(protagonist + " 'What are you talking about?'");
            Console.WriteLine("----");
            Console.WriteLine("Steve 'Well you've been spacing out for the last 5 minutes so obviously there's");
            Console.WriteLine("something going on.'");
            Console.WriteLine("----");
            Console.WriteLine(protagonist + " '....... Fine I was just thinking about my application.'");
            Console.WriteLine("----");
            Console.WriteLine("Steve 'Oh yeah your application for " + profession + ", what about it?'");
            Console.WriteLine("----");
            Console.WriteLine(protagonist + " 'I mean what if I don't get in?'");
            Console.WriteLine("----");
            Console.WriteLine("Steve 'Nah you're getting in alright, you're to dang passionate to get rejected.'");
            Console.WriteLine("Steve 'I mean let's be honest you've done more projects on the subject than I can count!'");
            Console.WriteLine("Steve 'So don't you worry about it.'");
            Console.WriteLine("----");
            Console.WriteLine(protagonist + " 'Thanks for that.'");
            Console.WriteLine("----");
            Console.WriteLine("Steve 'No thanks needed, however I wasen't kidding about almost being late so let's go!!!'");
            Console.WriteLine("----");
            Console.WriteLine(protagonist + " 'Oh right, yeah lets go.'");
        }
    }
}