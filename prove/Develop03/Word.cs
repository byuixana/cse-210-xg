public class Word
{
    private string _word;
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
    public void SetScripture(string word)
    {
        _word = word;
    }
    public void Display()
    {
        if(_isHidden == true)
        {
            
            foreach (char letter in _word)
                {
                    Console.WriteLine("_");
                }
            // Console.WriteLine(_hiddenWord + " ");
        }

        else
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