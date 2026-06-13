namespace ChaosFramework.Platform
{
    public static class WindowExt
    {
        public static float Ratio(this Window window)
            => window.width / (float)window.height;
    }
}