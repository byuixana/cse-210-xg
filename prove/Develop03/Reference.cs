public class Reference {
    string _book;
    int _chapter;
    int _startingVerse;
    int _endingVerse;
    bool _hasEndingVerse;


    public Reference(string book, int chapter, int startingVerse, int endingVerse=0) {
        _book = book;
        _chapter = chapter;
        _startingVerse = startingVerse;
        _endingVerse = endingVerse;
        if (_endingVerse != 0) {
            _hasEndingVerse = true;
        }
    }

    public string GetReferenceString() {
        if (_hasEndingVerse) {
            return $"{_book} {_chapter}:{_startingVerse}-{_endingVerse}";
        }
        else
            return $"{_book} {_chapter}:{_startingVerse}";
    }

    public void DisplayReference()
    {
        Console.WriteLine(GetReferenceString());
    }
    
    //   public string GetReference()
    // {
    //     return _reference;
    // }

    // public void SetReference(string reference)
    // {
    //     _reference = reference;
    // }
}