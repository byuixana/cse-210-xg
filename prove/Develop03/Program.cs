using System;

class Program
{
    static void Main(string[] args)
    {
        string user_scripture = "And after this manner was the language of my father in the praising of his God; for his soul did rejoice, and his whole heart was filled, because of the things which he had seen, yea, which the Lord had shown unto him.";
        Reference reference = new Reference("Nephi", 3, 7);
        Scripture scripture = new Scripture(user_scripture);
        Console.WriteLine("Hit enter to hide words or quit to end.");
        Console.Write(">");
        string continue_or_end = Console.ReadLine();
        scripture.scriptureFormat();
        reference.DisplayReference();
        bool end = false;

        while (end == false)
        {
            if (continue_or_end == "")
            {
                scripture.createWordList();
                scripture.HideWords();
                scripture.DisplayAltScripture();
            } else{
                Console.WriteLine("Goodbye!");
                end = true;
            }
            
        } 
        Console.WriteLine("Good work!");
    }
}