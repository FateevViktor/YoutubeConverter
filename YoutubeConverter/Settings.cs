using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeConverter
{
    class Settings
    {
        public YouTube YouTube { get; set; }
        public YouTubeVideo Video { get; set; }
        public string Url { get; set; }
        public string PathSave { get; set; }

        public Settings()
        {
            YouTube = YouTube.Default;
        }
        public void SetVideoUrl()
        {
            bool check = false;
            Console.WriteLine("Введите URL-ссылку:");

            while (check == false)
            {
                Url = Console.ReadLine();
                Console.WriteLine(Environment.NewLine + "Пытаюсь добраться до видео...");
                try
                {
                    Video = YouTube.GetVideo(Url);
                    check = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Неудача. Или видео не существует, или вы вводите неправильную ссылку.");
                    Console.WriteLine("Необходимо вводить что то типа такого https://www.youtube.com/watch?v=urKs68uf2B8");
                    Console.WriteLine("Попробуйте еще раз!");
                }
            }
        }
        public void SetPathSave()
        {
            string folder;
            folder = GetDefaultFolder();
            PathSave = Path.Combine(folder, Video.FullName); //Путь куда сохраняем
        }
        string GetDefaultFolder()
        {
            var home = Environment.GetFolderPath(
                Environment.SpecialFolder.UserProfile);

            return Path.Combine(home, "Downloads");
        }
    }
}
