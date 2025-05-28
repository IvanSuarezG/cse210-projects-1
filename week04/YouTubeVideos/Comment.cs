using System;
using System.Collections.Generic;

public class Comment
{
   
    public string _name;
    public string _textComment;
    public DateTime _date;


    public Comment(string name, string textComment, DateTime date)
    {
        _name = name;
        _textComment = textComment;
        _date = date;
    }
    public void DisplayComments()
    {
            Console.WriteLine($"{_date:yyyy-MM-dd} / {_name}");
            Console.WriteLine($"{_textComment}");
            Console.WriteLine();
    }

}
