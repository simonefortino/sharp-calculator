using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace SharpCalculator.Views;

public partial class ShortcutsWindow : Window
{
    public ShortcutsWindow()
    {
        InitializeComponent();
    }

    private void OnCloseButton(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}