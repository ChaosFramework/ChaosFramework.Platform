using ChaosFramework.Math.Vectors;

namespace ChaosFramework.Platform
{
    public interface Window : PresentationContext
    {
        /// <summary> The width in pixels. </summary>
        uint width { set; }

        /// <summary> The height in pixels. </summary>
        uint height { set; }

        /// <summary> The position in pixels. </summary>
        Vector2i position { set; }
    }
}
