using System;

class Program
{
    static void Main(string[] args)
    {
        string user_scripture = "I will go and do.";
        Reference reference = new Reference("Nephi", 3, 7);
        Scripture scripture = new Scripture(user_scripture, reference);
        // Console.WriteLine("Hit enter to hide words or quit to end.");
        // Console.Write(">");
        // string continue_or_end = Console.ReadLine();
        string continue_or_end = "";
        Console.WriteLine(scripture.scriptureFormat());
        scripture.createWordList();
        // reference.DisplayReference();

        bool end = false;

        while (end == false)
        {
            if (continue_or_end == "")
            {
                scripture.HideWords();
                scripture.DisplayAltScripture();
                Console.WriteLine("\nHit enter to hide words or quit to end.");
                Console.Write(">");
                continue_or_end = Console.ReadLine();
                Console.Clear();
                bool allWordsHidden = scripture.UpdateAllWordsHidden();
                if (allWordsHidden)
                {
                    end = true;
                }
            } else{
                Console.WriteLine("Goodbye!");
                end = true;
            }
            
        } 
        Console.WriteLine("Good work!");
    }
}