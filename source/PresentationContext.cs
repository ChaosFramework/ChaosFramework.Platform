using ChaosFramework.Math.Vectors;
using System.Collections.Generic;
using System.IO;

namespace ChaosFramework.Platform
{
    public interface PresentationContext
    {
        string title { get; set; }

        /// <summary> The width in pixels. </summary>
        uint width { get; }

        /// <summary> The height in pixels. </summary>
        uint height { get; }

        /// <summary> The position in pixels. </summary>
        Vector2i position { get; }

        /// <summary> Issues a front buffer swap for this context. </summary>
        void Present();

        /// <summary>
        ///     Sets the icon associated with the operating system level "window"
        ///     by attempting to parse each source stream in order until one of them is suitable.
        ///     If no source represents a suitable stream for the implementing platform, the operation shall have no effect.
        /// </summary>
        void SetIcon(IEnumerable<Stream> sources);
    }
}
