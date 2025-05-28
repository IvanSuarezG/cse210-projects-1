using System;
using System.Collections.Generic;


public class Video
{
    public string _title;
    public string _author;
    public int _length; // in seconds
    public List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Method to display video details
    public void DisplayVideoDetails()
    {
        Console.WriteLine("Video Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _length + " seconds");

        Console.WriteLine("Comments:");
        if (_comments.Count == 0)
        {
            Console.WriteLine("No comments yet.");
        }
        else
        {
            Console.WriteLine($"Total Comments: {GetCommentCount()}");
        }
        foreach (Comment comment in _comments)
        {
            comment.DisplayComments();

        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public int GetCommentCount()
    {
        return _comments.Count;
    }

}