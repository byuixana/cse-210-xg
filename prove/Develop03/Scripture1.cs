using System.Diagnostics.Metrics;

public class Scripture{
    private string _text;
    private List<Word> _wordList= new List<Word>();
    private List<int> _intList = new List<int>();
    private string [] _textArray;
    
     public Scripture(string text)
    {
        _text = text;
    }
    public bool wordHidden()
    {
        return _intList.Count > 0;
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
     public void createWordList()
    {
       string [] textArray = _text.Split();
    //    int _count = 0;
        foreach (string word in textArray)
        {
            _wordList.Add(new Word(word));
            // _intList.Add(_count);
        }
    }
    public void HideWords()
    {
        
        foreach (Word word in _wordList)
        {

            Random rnd = new Random();
            int randomWordIndex = rnd.Next(_wordList.Count());
            if (_wordList[randomWordIndex] == word)
            {
                Word hiddenWord = new Word(_textArray[randomWordIndex]);
            }

        }
    }
   
    public void DisplayAltScripture()
    {
        foreach(Word word in _wordList)
        { 
             word.Display();
        }
    }
}