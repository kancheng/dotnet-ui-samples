using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using System;
using System.Runtime.InteropServices;

namespace CalculatorAvalonia
{
    internal class Program
    {
        // 初始化碼。在 Avalonia 控制項初始化之前不要移除或變更此方法。
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia 配置，由 Avalonia UI 產生器使用。
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace()
                .UseReactiveUI();
    }
}
