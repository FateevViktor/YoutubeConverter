using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeConverter
{
    /// <summary>
    /// Команда для скачивания и сохранения видео
    /// </summary>
    internal class CommandSaveVideo : ICommand
    {
        ReceiverSaveVideo receiver;

        public CommandSaveVideo(ReceiverSaveVideo receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public void Run(Settings settings)
        {
            receiver.Operation(settings);
        }

        // Отменить
        public void Cancel()
        { }
    }
}
