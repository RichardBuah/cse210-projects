using System;
using System.Collections.Generic;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentList = new List<Comment>();

    // public Video(string title, string author, int length, Comment text)
    // {
    //     _title = title;
    //     _author = author;
    //     _length = (length*60);
    //     _commentList.Add(text);
    // }
    // public int GetCommentNumber()
    // {
    //     int commentNumber = _commentList.Count();
    //     return commentNumber;
    // }
    public string DisplayResult()
    {
        return $"{_author} {_title} {_length}";
    }
}