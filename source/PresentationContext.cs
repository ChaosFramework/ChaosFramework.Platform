using ChaosFramework.Math.Vectors;

namespace ChaosFramework.Platform
{
    public interface PresentationContext
    {
        string title { get; set; }

        // TODO: icon

        /// <summary> The width in pixels. </summary>
        uint width { get; }

        /// <summary> The height in pixels. </summary>
        uint height { get; }

        /// <summary> The position in pixels. </summary>
        Vector2i position { get; }

        /// <summary> Issues a front buffer swap for this context. </summary>
        void Present();
    }
}
