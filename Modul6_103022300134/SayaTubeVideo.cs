using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_103022300134
{
    class SayaTubeVideo
    {
        private int id;
        private string judul;
        private int playCount;


        public SayaTubeVideo(string judul)
        {
            if(judul == null)
            {
                throw new ArgumentException("Judul Video Tidak Boleh Kosong");
            }
            if(judul.Length > 100)
            {
                throw new ArgumentException("Judul Video Tidak Boleh Lebih Dari 100 Karakter");
            }

            Random rand = new Random();
            this.id = rand.Next(1000, 9999);
            this.judul = judul;
            this.playCount = 0;
        }

        public void increasePlayCount(int count)
        {
            if(count > 10000000)
            {
                throw new ArgumentOutOfRangeException("Play Count Tidak Boleh Lebih Dari 10.000.000");
            }

            try 
            {

                checked 
                { 
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException("Error : terjadi overflow pada playcount.");
            }
        }

        public void PrintVideoDetails() 
        { 
            Console.WriteLine("ID Video : " + this.id);
            Console.WriteLine("Judul Video : " + this.judul);
            Console.WriteLine("Play Count : " + this.playCount);
        }

        internal string GetJudul()
        {
            throw new NotImplementedException();
        }

        internal int GetPlayCount()
        {
            throw new NotImplementedException();
        }
    }
}
