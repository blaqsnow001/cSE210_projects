using System;
using System.Collections.Generic;

class Video
{
    public string Title;
    public string Author;
    public int LengthInSeconds;
    public List<Comment> Comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

// Simple Comment class so List<Comment> is a known type
class Comment
{
    public string Author;
    public string Text;

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }
}