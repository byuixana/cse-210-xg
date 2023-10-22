using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Nephi", 3, 7);
        Scripture scripture = new Scripture("And after this manner was the language of my father in the praising of his God; for his soul did rejoice, and his whole heart was filled, because of the things which he had seen, yea, which the Lord had shown unto him.");
        scripture.scriptureFormat();
        reference.DisplayReference();
        scripture.createWordList();
        
        
    }
}