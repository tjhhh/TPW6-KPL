using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tpmod6_103022300065
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount()
        {
            this.playCount++;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
}
