using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: Instead of using a single hardcoded scripture, this program
        // stores a small library of scriptures and randomly selects one each time
        // the program runs, so the user gets a different memorization challenge
        // every time they use the program.
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding."),
            new Scripture(new Reference("1 Nephi", 3, 7),
                "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("Mosiah", 2, 41),
                "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."),
            new Scripture(new Reference("Moroni", 10, 4, 5),
                "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.")
        };

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to end the program.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}