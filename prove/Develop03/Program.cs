using System;

class Program
{
    static void Main(string[] args)
    {
        string user_scripture = "I will go and do the things the Lord commands, for I know the Lord giveth no commandment unto the children of men save He shall prepare a way to accomplish the things which he hath commanded them.";
        Reference reference = new Reference("Nephi", 3, 7);
        Scripture scripture = new Scripture(user_scripture, reference);
        // Console.WriteLine("Hit enter to hide words or quit to end.");
        // Console.Write(">");
        // string continue_or_end = Console.ReadLine();
        Console.WriteLine(reference.GetReferenceString());
        Console.WriteLine(scripture.scriptureFormat());
        Console.WriteLine("\nHit enter to hide words or quit to end.");
        Console.Write(">");
        string continue_or_end = Console.ReadLine();
        Console.WriteLine(scripture.scriptureFormat());
        scripture.createWordList();
        // reference.DisplayReference();
        bool allWordsHidden = false;
        bool end = false;

        while (end == false)
        {
            if (continue_or_end == "")
            {
                Console.Clear();
                scripture.HideWords();
                scripture.DisplayAltScripture();
                if (allWordsHidden)
                {
                    end = true;
                }
                Console.WriteLine("\nHit enter to hide words or quit to end.");
                Console.Write(">");
                continue_or_end = Console.ReadLine();
                Console.Clear();
                allWordsHidden = scripture.UpdateAllWordsHidden();
            } else{
                end = true;
            }
            
        } 
        Console.WriteLine("Good work! Goodbye!");
    }
}