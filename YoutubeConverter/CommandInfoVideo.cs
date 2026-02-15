using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeConverter
{
    /// <summary>
    /// Команда, которая выводит информацию о видео
    /// </summary>
    internal class CommandInfoVideo : ICommand
    {
        ReceiverInfoVideo receiver;

        public CommandInfoVideo(ReceiverInfoVideo receiver)
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
