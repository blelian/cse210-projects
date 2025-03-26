using System;
using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int Length)
    {
        _title = title;
        _author = author;
        _length = Length;
    }
    public int CommentCount(){
        return _comments.Count;
    }
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({CommentCount()}):");
        foreach( Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}