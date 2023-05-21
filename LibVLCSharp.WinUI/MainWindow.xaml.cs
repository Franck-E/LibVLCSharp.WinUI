using LibVLCSharp.Platforms.Windows;
using LibVLCSharp.Shared;
using Microsoft.UI.Xaml;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace LibVLCSharp.WinUI;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{

    private MovieWindow? mWindow { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
        var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
        var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);

        appWindow.Resize(new Windows.Graphics.SizeInt32 { Width = 360, Height = 420 });
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        mWindow = new MovieWindow();
        mWindow.Activate();
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        mWindow.Close();
    }
}
