using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("Welcome to your journal!");

        // Create entry list using Journal class.
        Journal temporary_entries = new Journal();

        // Number variable
        int num_user_response = 1;
                
               
            while (num_user_response != 5)
            {
                Console.WriteLine("Select one of these options: \n1)Write\n2)Display \n3)Save \n4)Load \n5)End");
                Console.Write("What would you like to do?");
                string user_response = Console.ReadLine();
                num_user_response = int.Parse(user_response);
                if (num_user_response == 1)
                {
                    Prompt promptObject = new Prompt();   

                    // Gets prompt.  
                    string prompt = promptObject.GetPrompt();

                    // Writes prompts.
                    Console.WriteLine(prompt);

                    // User entry.
                    Console.Write(">");

                    // Reads user entry.
                    string user_input = Console.ReadLine(); 

                    Console.Write("Your name:");
                    
                    string user_name = Console.ReadLine();

                    Entry user_entry = new Entry(prompt, user_input, user_name);

                    temporary_entries.addEntry(user_entry);
                }
                else if (num_user_response == 2)
                {
                    temporary_entries.DisplayEntries();
                }
                else if (num_user_response == 3)
                {
                    Console.Write("Filename:");
                    string user_file = Console.ReadLine();
                    temporary_entries.CreateFile(user_file);

                }
                else if (num_user_response == 4)
                {
                    // Console.Write("Name:");
                    Console.Write("Filename:");
                    string load_file = Console.ReadLine();
                    Journal returned_file = new Journal();
                    returned_file.LoadFile(load_file);
                }
                else
                {
                    Console.WriteLine("Great job recording your thoughts!");
                }
            }
                

            





       
       
    // Keep everything in memory, then give them an option to save. DO NOT save every entry.
    // CLasses
    // Journal - save, load journal, show entries. Unecessary: delete function.
    // Entry - contains date, prompt, response. Unecessary: update_entry.
    // Prompt - List<string> prompts.display, add. 
    }
}