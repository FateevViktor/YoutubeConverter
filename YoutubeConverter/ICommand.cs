using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeConverter
{
    interface ICommand
    {
        void Run(Settings settings);
        void Cancel();
    }
}
