using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WMPLib;

namespace Snake
{
    class Music
    {
        string path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
        //WindowsMediaPlayer wmp = new WindowsMediaPlayer(); //создаем медиаплеер
        public void Play() //создаем метод
        {
           // wmp.URL = Path.Combine(path, @"minecraft.mp3"); 
          //  wmp.settings.volume = 50;
           // wmp.controls.play();
          //  wmp.settings.setMode("loop", true);
        }
        public void DeathSound()
        {
          //  wmp.URL = Path.Combine(path, @"death.mp3");
          //  wmp.settings.volume = 50;
          //  wmp.controls.play();
        }
        public void Stop()
        {
          //  wmp.settings.setMode("loop", false);
          //  wmp.controls.stop();
        }

    }

}