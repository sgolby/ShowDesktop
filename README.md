# Show Desktop

[![Latest release](https://img.shields.io/github/v/release/sgolby/ShowDesktop?label=release&color=2ea44f)](https://github.com/sgolby/ShowDesktop/releases/latest)
[![Platform](https://img.shields.io/badge/platform-Windows%2010%20%2F%2011-0078D6?logo=windows&logoColor=white)](https://github.com/sgolby/ShowDesktop)
[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![License: MIT](https://img.shields.io/github/license/sgolby/ShowDesktop?color=blue)](LICENSE)

A tiny Windows utility that shows the desktop. Run it once to minimize all windows; run it again to restore them.

## The Problem

1. Don't have a keyboard on your lounge room gaming PC to press Win+D to get to the desktop? 🎮
2. Too many icons on your taskbar, so you can't even find a spot to right click and 'Show Desktop'? 🖥️


This utility solves 2 of my annoying problems, retro PC has a joystick to mouse input but no easy way to get to the desktop, or flip back to Emulation Station DE without getting up and grabbing a keyboard. My desktop PC has a long row of Taskbar icons and I've run out of room to right click and Show Desktop. (it's also a complete pain doing the right click and hold while on my TV PC)

## Download

Grab the latest `ShowDesktop.exe` from the [Releases](https://github.com/sgolby/ShowDesktop/releases/latest) page. No installer, no dependencies - just run it.

## FAQ

**The build size is absurd!**
</br>Yep.
</br>That's the joy of .NET.   On a modern PC this is just one disk 'seek' and the util will be in memory and run nearly instantly afterwards.

**I could just press Win+D!**
<br>Yep.
<br>Good luck doing that on a PC without a keyboard. (that's the whole point of this utility)

**Will my antivirus flag it?**
</br>Possibly. The tiny AOT build does get flagged on some systems.
</br>The app also uses `keybd_event` to simulate keypresses, which some heuristic scanners treat as suspicious. It contains no malicious code - build it yourself from the source here to verify.



## Build from source

Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

```
dotnet build ShowDesktop.csproj
```

### Build configurations

| Configuration | Description |
|---|---|
| `Debug` | Standard debug build |
| `Release` | Self-contained single-file `.exe` for `win-x64` |
| `SmallRelease` | Same as Release but with trimming enabled (smaller file) |
| `Tiny` | AOT-compiled (smallest possible, no .NET runtime needed) |

To publish a self-contained release build:

```
dotnet publish ShowDesktop.csproj -c Release
```



## License

MIT — see [LICENSE](LICENSE).
