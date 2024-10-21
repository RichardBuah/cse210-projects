using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class Comment
{
    public string _name;
    public string _handle;
    public string _text;
    public string GetDisplayText()
    {
        return $"{_name}    {_handle}   {_text}";
    }
}
