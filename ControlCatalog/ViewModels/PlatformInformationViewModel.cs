using System;
using System.Runtime.InteropServices;
using Avalonia;
using Avalonia.Platform;
using MiniMvvm;

namespace ControlCatalog.ViewModels;
#nullable enable

public class PlatformInformationViewModel : ViewModelBase
{
    public PlatformInformationViewModel()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            PlatformInfo = "Platform: OSX";
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            PlatformInfo = "Platform: Linux";
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            PlatformInfo = "Platform: Windows";
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("Android")))
            PlatformInfo = "Platform: Android";
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("iOS")))
            PlatformInfo = "Platform: iOS";
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("Browser")))
            PlatformInfo = "Platform: Browser";
        else
            PlatformInfo = "Unknown OS platform " + RuntimeInformation.OSDescription;
    }

    public string PlatformInfo { get; }
}