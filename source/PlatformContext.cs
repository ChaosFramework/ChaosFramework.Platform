namespace ChaosFramework.Platform
{
    public delegate void Overhead();

    public interface PlatformContext
    {
        /// <summary> If not null, this describes how the platform can be used to target the OpenGL API. </summary>
        GlContext glContext { get; }

        Window CreateWindow(string title);
        Fullscreen CreateFullscreen(string title);

        /// <summary> Raised when the process receives a signal from the OS that it should be terminated. </summary>
        event System.Action Terminate;

        /// <summary> Processes incoming operating system level events. </summary>
        Overhead messageQueue {get;}
    }
}
