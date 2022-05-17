namespace TK_Projekt_2
{
    using System;
    using System.IO;

    public class VideoData
    {
        public Uri Uri { get; }

        public string Description { get; }

        public VideoData(string fileName, string description)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Videos", $"{fileName}.mp4");

            this.Uri = new Uri(path);
            this.Description = description;
        }

        public static VideoData[] Videos { get; } = new VideoData[] {
            new VideoData("norwid", NorwidDescription),
            new VideoData("slowacki", SlowackiDescription),
            new VideoData("pawlikowska", PawlikowskaDescription)
        };

        private const string NorwidDescription = "aaaaaaaaaaaaa";

        private const string SlowackiDescription = "bbbbbbbbbbbbbbb";

        private const string PawlikowskaDescription = "cccccccccccccc";
    }
}