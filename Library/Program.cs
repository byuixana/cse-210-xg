// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public void DisplayAnimation(){
        List<string> _animationStrings = new List<string>;
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");

        foreach (string s in _animationStrings){
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Done.")
    }

DisplayAnimation()