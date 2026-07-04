using System.IO;

namespace ChaosFramework.Platform
{
    public record class ApplicationIcon(ApplicationIcon.IconFormat format, ApplicationIcon.GetStream getStream)
    {
        public delegate Stream GetStream();

        public enum IconFormat { ico };

        public readonly IconFormat format = format;
        public readonly GetStream getStream = getStream;
    }
}
