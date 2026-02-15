using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeConverter
{
    internal class ReceiverSaveVideo
    {
        public void Operation(Settings settings)
        {
            Console.WriteLine("Сохраним по адресу: " + settings.PathSave);
            Console.WriteLine("Необходимо подождать, сохраняю...");
            File.WriteAllBytes(settings.PathSave, settings.Video.GetBytes());
            Console.WriteLine("Готово - наслаждайтесь!");
            Console.ReadLine();
        }
    }
}
