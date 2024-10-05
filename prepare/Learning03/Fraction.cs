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

    public int GetTopValue()
    {
        return _topNumber;
    }

    public void SetTopValue(int topNum)
    {
        _topNumber = topNum;
    }

    public int GetBottomValue()
    {
        return _bottomNumber;
    }

    public void SetBottomValue(int botNum)
    {
        _bottomNumber = botNum;
    }

    public string GetFractionString()
    {
        string strTop = GetTopValue().ToString();
        string strBottom = GetBottomValue().ToString();
        string fractionString = strTop + "/" + strBottom;
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_topNumber/(double)_bottomNumber;
        return decimalValue;
    }
}