using System.Diagnostics.Metrics;

public class Scripture{
    private string _text;
    private string _word;
    private List<Word> _wordList= new List<Word>();
    private List<int> _intList = new List<int>();
    
     public Scripture(string text)
    {
        _text = text;
    }

   
    public string GetScripture()
    {
        return _text;
    }

    public void SetScripture(string text)
    {
        _text = text;
    }

    public void scriptureFormat()
    {
        string scriptureFormat =  $"{_text}";
        // return scriptureFormat;
        Console.WriteLine(scriptureFormat);
    }
     public List<Word> createWordList()
    {
       string [] textArray = _text.Split();
        foreach (string word in textArray)
        {
            _wordList.Add(new Word(word));
        }
        return _wordList;
    }

    public Word HideWord()
        {
            // createWordList();
            Random rnd = new Random();
            int randomWordIndex = rnd.Next(_wordList.Count);
            Word wordToHide = _wordList[randomWordIndex];
            foreach (Word word in _wordList)
            {
                if (wordToHide == word)
                {
                    Word hiddenWord = new Word("_ _ _ _");
                    wordToHide = hiddenWord;
                } else{
                    wordToHide = _wordList[randomWordIndex];
                }
            }
            return wordToHide;
        }
    public void DisplayAltScripture(List <Word> wordList)
        {
            foreach(Word word in wordList)
            {
                word.Display();
            }
        }

}