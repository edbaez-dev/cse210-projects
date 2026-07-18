using System;

//Creativity and exceeding requirements:
// 1. The journal is saved and loaded using a real CSV format instead of a simple
//    delimiter. Fields are wrapped in quotes and internal quotes are escaped by
//    doubling them, and commas inside entry text are handled correctly during
//    loading (Entry.SaveEntry and Journal.ParseCsvLine).This means the saved
//    file can be opened directly and correctly in Excel or Google Sheets.
// 2. Added personal prompts to the PromptGenerator list, beyond the example
//    prompts provided in the assignment.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                DateTime today = DateTime.Now;
                string date = today.ToShortDateString();

                Entry newEntry = new Entry(date, prompt, response);
                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Not a valid option, please try again.");
            }
        }
    }
}