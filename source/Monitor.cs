using ChaosFramework.Math.Vectors;

namespace ChaosFramework.Platform
{
    public interface Monitor
    {
        /// <summary> The width in pixels. </summary>
        uint width { get; }

        /// <summary> The height in pixels. </summary>
        uint height { get; }

        /// <summary> The position in pixels. </summary>
        Vector2i position { get; }

        /// <summary> The name of the logical device. </summary>
        string deviceName { get; }
    }
}
