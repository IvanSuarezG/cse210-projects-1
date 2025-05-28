using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# programming tutorial #1", "Professor Sluiter", 250);
        Comment comment1 = new Comment("Mac Maring", "I watched in 2 x speed. I became a C# developer in 2 minutes.", DateTime.Parse("2023-10-01"));
        Comment comment2 = new Comment("John Doe", "I know everything about C# now. you have a talent for explaining things.", DateTime.Parse("2020-05-01"));
        Comment comment3 = new Comment("Jane Smith", "This is the best C# tutorial I've ever seen!", DateTime.Parse("2022-01-13"));

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.DisplayVideoDetails();

        Video video2 = new Video("What is a PLC and how does its works?", "Abel Nuñez", 1933);
        Comment comment4 = new Comment("Rogelio Avila", "Thanks for share your knowledge, I learned a lot.", DateTime.Parse("2022-05-08"));
        Comment comment5 = new Comment("Leonardo Farías", "I have been working with PLCs for 10 years, and I still learned something new today.", DateTime.Parse("2024-09-15"));
        Comment comment6 = new Comment("Juan Argento", "I like the information related to the PLCs and how they works. Your course is fundamental in process to come into the world of automation.", DateTime.Parse("2024-11-20"));
        Comment comment7 = new Comment("Sergio Carrasco", "I have been learning more about PLCs with your videos than with my university classes. Thank you very much for sharing your knowledge.", DateTime.Parse("2019-07-08"));
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.DisplayVideoDetails();

        Video video3 = new Video("How to make a simple game in Unity", "Stanley", 1800);
        Comment comment8 = new Comment("Alice Johnson", "Great tutorial! I was able to create my first game in Unity.", DateTime.Parse("2025-01-31"));
        Comment comment9 = new Comment("Bob Brown", "I struggled with the physics part, but your explanation helped a lot.", DateTime.Parse("2024-09-18"));
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.DisplayVideoDetails();
    }
}