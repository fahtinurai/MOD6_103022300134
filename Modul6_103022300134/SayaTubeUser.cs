using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_103022300134
{
    class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploudedVideos;

        public SayaTubeUser(string username)
        {
            if (username == null)
            {
                throw new ArgumentException("Username Tidak Boleh Kosong");
            }
            if (username.Length > 100)
            {
                throw new ArgumentException("Username Tidak Boleh Lebih Dari 100 Karakter");
            }
            Random rand = new Random();
            this.id = rand.Next(1000, 9999);
            this.username = username;
            this.uploudedVideos = new List<SayaTubeVideo>();
        }

        public void UploadVideo(SayaTubeVideo video)
        {
            if (video == null)
            {
                throw new ArgumentException("Video Tidak Boleh Kosong");
            }
            this.uploudedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (SayaTubeVideo video in this.uploudedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void PrintAllVideoPlaycount() 
        { 
            Console.WriteLine($"User :  {username}");
            int count = 0;
            foreach (var video in uploudedVideos)
            {
                if (count >= 8)
                {
                    break;
                    Console.WriteLine($"ID Video {count + 1} judl : " + video.GetJudul());
                }
            }
        }
    }
}
