namespace TK_Projekt_2
{
    using System;
    using System.IO;

    public class VideoData
    {
        public Uri Source { get; }

        public string Description { get; }

        public VideoData(string fileName, string description)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Videos", $"{fileName}.mp4");

            this.Source = new Uri(path);
            this.Description = description;
        }

        public static VideoData[] Videos { get; } = new VideoData[] {
            new VideoData("norwid", "Cyprian Kamil Norwid \"Nerwy\""),
            new VideoData("slowacki", "Juliusz Słowacki \"Chmury\""),
            new VideoData("pawlikowska", "Maria Pawlikowska-Jasnorzewska \"Fotografia\"")
        };
    }
}