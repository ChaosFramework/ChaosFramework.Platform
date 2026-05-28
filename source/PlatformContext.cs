namespace ChaosFramework.Platform
{
    public interface PlatformContext
    {
        PrimaryWindow primaryWindow { get; }
        void Setup();
        void Present();
    }
}