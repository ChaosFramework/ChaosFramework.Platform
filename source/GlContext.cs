namespace ChaosFramework.Platform
{
    public interface GlContext
    {
        void Init();

        void MakeCurrent(PresentationContext context);
    }
}
