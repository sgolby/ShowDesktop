using System;
using System.Runtime.InteropServices;

[DllImport("user32.dll")]
static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, nuint dwExtraInfo);

const byte VK_LWIN = 0x5B;
const uint KEYEVENTF_KEYUP = 0x0002;

keybd_event(VK_LWIN, 0, 0, 0);
keybd_event((byte)'D', 0, 0, 0);
keybd_event((byte)'D', 0, KEYEVENTF_KEYUP, 0);
keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, 0);

Environment.Exit(0);