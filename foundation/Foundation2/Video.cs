using System;
using System.Collections.Generic;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentList = new List<Comment>();
    public void AddComment(Comment text)
    {
        _commentList.Add(text);
    }
    public int GetCommentNumber()
     {
         int commentNumber = _commentList.Count();
         return commentNumber;
    }
    public string GetDisplayText()
    {
        return $"Title          Author        Lenght      Number of Comments\n{_title}     {_author}       {_length} minutes        {GetCommentNumber()}";
    }
}