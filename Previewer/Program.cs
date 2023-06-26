using Avalonia;

namespace Previewer
{
    internal class Program
    {
        public static AppBuilder BuildAvaloniaApp()
          => AppBuilder.Configure<App>()
                .UsePlatformDetect().LogToTrace();

        public static int Main(string[] args)
          => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }
}