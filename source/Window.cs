namespace ChaosFramework.Platform
{
    public interface Window
    {
        /// <summary> The width in pixels. </summary>
        int width { get; }

        /// <summary> The height in pixels. </summary>
        int height { get; }

        /// <summary> Issues a front buffer swap for this window. </summary>
        void Present();
    }
}