using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        // Initialize to 1/1
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        // Initialize only bottom number
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        // Get both top and bottom numbers
        _topNumber = top;
        _bottomNumber = bottom;
    }
}