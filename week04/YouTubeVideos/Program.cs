using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Struggles Of Learning C#", "Blessing Mpofu", 240);
        video1.AddComment("Floerence Jorge", "It's true C# is not very easy to learn.");
        video1.AddComment("Bellinda Mpofu", "I now understand why my brother never sleeps.");
        video1.AddComment("Arone Costa", "If it's like that, then I will never learn C#.");

        Video video2 = new Video("The Power Of Introducing Code To Africa", "Blessing Mpofu", 300);
        video2.AddComment("Florence Jorge", "Good things are not easy to get.");
        video2.AddComment("Bellinda Mpofu", "Keep on working then bro.");
        video2.AddComment("Arone Costa", "I am now reconsidering learning C#.");

        Video video3 = new Video("Understanding OOP in C#", "Blessing Mpofu", 180);
        video3.AddComment("Ntandoyenkosi Dale", "This is very helpful, thank you!");
        video3.AddComment("Yemurai Chamuturikwa", "I love this explanation.");
        video3.AddComment("Joe Mudzingwa", "Great content!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}