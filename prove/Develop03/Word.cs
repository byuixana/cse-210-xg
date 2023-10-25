public class Word
{
    private string _word;
    private char [] _letterList;
    private string _hiddenWord;
    private int _letterCount;
    private bool _isHidden = false;
    public Word(string word)
    {
        _word = word;
    }

    public string GetWord(){
        return _word;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public void Display()
    {
         if(_word == "." || _word == ",")
            {
                _isHidden = false;
                if(_isHidden == true)
                    {
                        _letterList = _word.ToCharArray();

                        foreach (char letter in _letterList)
                            {
                                    Console.Write(" _ ");
                            }
                    }
                else
                {
                    Console.Write(_word + " ");
                }
            }
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public void HideWord()
    {
        _isHidden = true;
    }

}