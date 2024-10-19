using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class Comment
{
    public string _name;
    public string _handle;
    public string _text;

    // public Comment(string name, string handle, string text)
    // {
    //     _name = name;
    //     _handle = handle;
    //     _text = text;
    // }
    public string GetDisplayText()
    {
        return $"{_handle} {_text}";
    }
}
