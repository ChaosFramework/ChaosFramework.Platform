using ChaosFramework.Math.Vectors;
using ChaosFramework.Graphics.Imaging;

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

        /// <summary> Set the icon associated with the operating system level "window". </summary>
        void SetIcon(Icon icon);
    }
}
