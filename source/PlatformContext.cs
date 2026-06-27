using System.Collections.Generic;

namespace ChaosFramework.Platform
{
    public delegate void Overhead();

    public interface PlatformContext
    {
        /// <summary> If not null, this describes how the platform can be used to target the OpenGL API. </summary>
        GlContext glContext { get; }

        /// <summary>
        ///     Enumerates all currently connected logical monitors,
        ///     ordered by their index as assigned by the operating system.
        /// </summary>
        /// <remarks>
        ///     There is no guarantee that when queried multiple times,
        ///     the logical monitors are represented by the same <see cref="Monitor"/> instances.
        /// </remarks>
        IEnumerable<Monitor> EnumerateMonitors();

        /// <summary> Creates a windowed PresentationContext. </summary>
        /// <param name="title"> The title of the operating system level "window". </param>
        /// <returns> The created windowed PresentationContext. </returns>
        Window CreateWindow(string title);

        /// <summary> Creates a full screen PresentationContext on the provided monitor. </summary>
        /// <param name="title"> The title of the operating system level "window". </param>
        /// <param name="monitor"> The monitor to present on. </param>
        /// <exception cref="ArgumentException">Thrown if the provided monitor is of an unsupported type.</exception>
        /// <returns> The created fullscreen PresentationContext. </returns>
        Fullscreen CreateFullscreen(string title, Monitor monitor);

        /// <summary> Raised when the process receives a signal from the operating system that it should be terminated. </summary>
        event System.Action Terminate;

        /// <summary> Processes incoming operating system level events. </summary>
        Overhead messageQueue { get; }
    }
}
