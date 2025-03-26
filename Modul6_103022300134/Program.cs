using Modul6_103022300134;
using System;

class Program
{ 
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Review film oleh Ade_103022300134");

        for (int i = 1; i <= 10; i++) 
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film  {i} - Judul" );
            video.increasePlayCount(i * 1000);
            user.UploadVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine("Total Play Count : " + user.GetTotalVideoPlayCount());   
        Console.ReadLine();
    }
}