using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace DummyEveLauncher
{
    static class Program
    {
        static void Main(string[] args)
        {
            Process.Start("Launcher\\evelauncher.exe", String.Join(" ", args));
        }
    }
}
