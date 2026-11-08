using Avalonia;

namespace AtomUI.DataGrid.LicenseTest;

internal static class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithAtomUIDefaultOptions()
            .LogToTrace()
            .StartWithClassicDesktopLifetime(args);
    }
}
