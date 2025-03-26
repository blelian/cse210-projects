using System;
public class Comment
{
    public string _commentName;
    public string _commentText;
    public Comment(string name, string text)
    {
        _commentName = name;
        _commentText = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_commentName}: {_commentText}");
    }
}