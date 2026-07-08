using System.IO;

namespace ChaosFramework.Platform
{
    /// <summary> Represents an icon to be propagated to the underlying platform. </summary>
    /// <param name="format"><inheritdoc cref="format"/></param>
    /// <param name="getStream"><inheritdoc cref="getStream"/></param>
    public class ApplicationIcon(ApplicationIcon.IconFormat format, ApplicationIcon.GetStream getStream)
    {
        /// <summary> Opens a stream for reading. </summary>
        public delegate Stream GetStream();

        /// <summary>
        ///     Supported stream formats for <see cref="ApplicationIcon">.
        ///     Each platform MUST support all of these formats.
        /// </summary>
        public enum IconFormat
        {
            /// <summary> The stream contains .ico data. </summary>
            ico
        };

        /// <summary> The internal format of the resource stream returned by <see cref="getStream"/>. </summary>
        public readonly IconFormat format = format;

        /// <summary>
        ///     Opens a resource stream with the underlying format specified by <see cref="format"/> for reading.
        ///     The caller is responsible for disposing the stream.
        /// </summary>
        public readonly GetStream getStream = getStream;
    }
}
