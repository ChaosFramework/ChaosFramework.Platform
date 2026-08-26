using ChaosFramework.Math.Vectors;

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
        ///     Attempts to set the icon associated with the operating system level "window".
        ///     If setting an icon is not supported at all, this shall have no effect by default.
        ///     Otherwise this shall accept (and convert if need be) any format listed in <see cref="ApplicationIcon.IconFormat"/>.
        /// </summary>
        void SetIcon(ApplicationIcon icon);

        /// <summary> Closes the underlying operating system level "window". </summary>
        void Close();
    }
}
