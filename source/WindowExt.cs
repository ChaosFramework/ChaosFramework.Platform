namespace ChaosFramework.Platform
{
    public static class WindowExt
    {
        public static float Ratio(this PresentationContext window)
            => window.width / (float)window.height;
    }
}
