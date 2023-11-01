public class Word
{
    private string _word;
    private char[] _letterArray;
    private string _hiddenWord;
    private int _index = 0;

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
                if(_isHidden == true)
                    {
                        _letterArray = _word.ToCharArray();
                        foreach (char letter in _letterArray)
                        {
                            for (int i = 0; i < _letterArray.Length; i++)
                                {
                                    // if (_letterArray[i] != '.' || _letterArray[i])
                                   
                                       
                                    _letterArray[i] = '_';
                                }
                        } 
                        string wordCombined = string.Join("", _letterArray.ToArray() );
                        Console.Write(wordCombined + " ");        
                    } else
                        {
                            Console.Write(_word + " ");
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