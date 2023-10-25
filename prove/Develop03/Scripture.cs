using System.Diagnostics.Metrics;

public class Scripture{

    private Reference _reference;

    private bool _allWordsHidden = false;
    private string _text;
    private string _word;
    private List<Word> _wordList= new List<Word>();
    private List<int> _intList = new List<int>();
    
     public Scripture(string text, Reference reference)
    {
        _text = text;
        _reference = reference;
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
    }
     public void createWordList()
    {
       string [] textArray = _text.Split();
        foreach (string word in textArray)
        {
            _wordList.Add(new Word(word));
        }
        // return _wordList;
    }

    public bool UpdateAllWordsHidden()
    {
        // look through all words and see if they are all hidden
        // if so, change it to true;
        return false;
    }

    public void HideWords()
        {
            // createWordList();
            Random rnd = new Random();
            int randomWordIndex = rnd.Next(_wordList.Count);
            while(_wordList[randomWordIndex].GetIsHidden()==true)
            {
                randomWordIndex = rnd.Next(_wordList.Count);

            }
            _wordList[randomWordIndex].HideWord();
        }

    public void DisplayAltScripture()
        {
            _reference.DisplayReference();
            foreach(Word word in _wordList)
            {
                word.Display();
            }
        }

}