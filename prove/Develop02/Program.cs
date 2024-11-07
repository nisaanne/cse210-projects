using System;

class Program
{
    static void Main(string[] args)
    {
        _Journal journal = new _Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.WriteNewEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter the filename to save the journal:");
                string saveFilename = Console.ReadLine();
                journal.SaveJournal(saveFilename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter the filename to load the journal:");
                string loadFilename = Console.ReadLine();
                journal.LoadJournal(loadFilename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose again.");
            }
        }
    }
}