using System.Diagnostics;

public class Fraction{
    private int _top = 0;
    private int _bottom = 0;

    // General fraction constructor.
    public Fraction()
    {
       _top = 1;
       _bottom = 1;
    }   
    // Whole number fraction consrtuctor.
   public Fraction(int wholeNumber)
   {
    
    // Automatically sets the bottom number to 1.
        _top = wholeNumber;
        _bottom = 1;
   }
   public Fraction(int top, int bottom)
   {
        // Generally creates a fraction.
        _top = top;
        _bottom = bottom;
   }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fraction_string = $"{_top} / {_bottom}";
        return fraction_string;
    }
    public double GetDecimalValue(double top, double bottom)
    {
        return double.Round(top / bottom, 2);
    }
    
}