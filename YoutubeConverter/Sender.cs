using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeConverter
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    internal class Sender
    {
        ICommand _command;
        string PathSave { get; set; }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        // Выполнить
        public void Run(Settings settings)
        {
            _command.Run(settings);
        }

        // Отменить
        public void Cancel()
        {
            _command.Cancel();
        }
    }
}
