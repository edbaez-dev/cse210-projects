using System;

class Program
{
    static void Main(string[] args)
    {
        // This program demonstrates the principles of Abstraction, Encapsulation, and Inheritance
        // by having a base Activity class and three derived classes (BreathingActivity,
        // ListingActivity, ReflectingActivity) that share common attributes and behaviors.
        
        // To exceed the core requirements, the program keeps a count of how many times each
        // activity has been performed during this session and displays it in the menu.

        bool keepRunning = true;

        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (keepRunning)
        {
            Console.WriteLine();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine($"1. Breathing Activity (completed {breathingCount} times)");
            Console.WriteLine($"2. Reflecting Activity (completed {reflectingCount} times)");
            Console.WriteLine($"3. Listing Activity (completed {listingCount} times)");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}