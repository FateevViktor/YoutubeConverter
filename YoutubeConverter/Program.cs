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
    /// Клиентский код
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings settings = new Settings();
            settings.SetVideoUrl();
            settings.SetPathSave();
            Console.WriteLine(settings.Url);

            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiverInfoVideo = new ReceiverInfoVideo();
            // создадим команду
            var commandInfoVideo = new CommandInfoVideo(receiverInfoVideo);
            // инициализация команды
            sender.SetCommand(commandInfoVideo);
            //  выполнение
            sender.Run(settings);

            // создадим получателя
            var receiverSaveVideo = new ReceiverSaveVideo();
            // создадим команду
            var commandSaveVideo = new CommandSaveVideo(receiverSaveVideo);
            // инициализация команды
            sender.SetCommand(commandSaveVideo);
            //  выполнение
            sender.Run(settings);

        }
    }
}