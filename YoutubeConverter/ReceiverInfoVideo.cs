using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeConverter
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    internal class ReceiverInfoVideo
    {
        public void Operation(Settings settings)
        {
            Console.WriteLine(Environment.NewLine+"Информация о видео:");

            Console.WriteLine("Название: " + settings.Video.Info.Title);
            Console.WriteLine("Автор: " + settings.Video.Info.Author);
            Console.WriteLine("Длина видео в секундах: " + settings.Video.Info.LengthSeconds + Environment.NewLine);
        }
    }
}
