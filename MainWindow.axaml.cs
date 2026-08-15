using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Styling;

namespace SharpCalculator;

public partial class MainWindow : Window
{
    private Calculator _calculator;
    
    public MainWindow()
    {
        _calculator = new Calculator();
        
        InitializeComponent();
    }

    // Numeric button click handler
    private void OnNumberClick(object? sender, RoutedEventArgs e)
    {
        if (sender is Button { Content: not null } button)
        {
            string number =  button.Content.ToString()!;
            MainTextBox.Text = _calculator.PressNumber(MainTextBox.Text ?? "0", number);
        }
    }
    
    // Operation button click handler
    private void OnOperatorClick(object? sender, RoutedEventArgs e)
    {
        if (sender is Button { Content: not null } button)
        {
            string op = button.Content.ToString()!;
            MainTextBox.Text = _calculator.PressOperator(MainTextBox.Text ?? "0", op);
        }
    }
    
    // Equals
    private void OnEqualsClick(object? sender, RoutedEventArgs e)
    {
        MainTextBox.Text = _calculator.PressEquals(MainTextBox.Text ?? "0");
    }


    private void OnClearClick(object? sender, RoutedEventArgs e)
    {
        MainTextBox.Text = _calculator.Clear();
    }

    private void OnKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyModifiers.HasFlag(KeyModifiers.Control))
        {
            if(e.Key is Key.T)
                ToggleTheme();
                
        }
        
        var (val, type) = e.Key switch
        {
            // Numeri (Tastiera standard e Tastierino)
            Key.D0 or Key.NumPad0 => ("0", "NUMBER"),
            Key.D1 or Key.NumPad1 => ("1", "NUMBER"),
            Key.D2 or Key.NumPad2 => ("2", "NUMBER"),
            Key.D3 or Key.NumPad3 => ("3", "NUMBER"),
            Key.D4 or Key.NumPad4 => ("4", "NUMBER"),
            Key.D5 or Key.NumPad5 => ("5", "NUMBER"),
            Key.D6 or Key.NumPad6 => ("6", "NUMBER"),
            Key.D7 or Key.NumPad7 => ("7", "NUMBER"),
            Key.D8 or Key.NumPad8 => ("8", "NUMBER"),
            Key.D9 or Key.NumPad9 => ("9", "NUMBER"),

            // Operatori
            Key.Add => ("+", "OPERATOR"),
            Key.Subtract or Key.OemMinus => ("-", "OPERATOR"),
            Key.Multiply => ("*", "OPERATOR"),
            Key.Divide => ("/", "OPERATOR"),

            // Azioni speciali
            Key.Enter or Key.Return => ("=", "EQUALS"),
            Key.Back => ("BACKSPACE", "CLEAR"),
            Key.Escape => ("ESCAPE", "CLEAR"),

            // Tasto non gestito
            _ => (string.Empty, "UNKNOWN")
        };

        switch (type)
        {
            case "NUMBER":
                MainTextBox.Text = _calculator.PressNumber(MainTextBox.Text ?? "0", val);
                break;
            case "OPERATOR":
                MainTextBox.Text = _calculator.PressOperator(MainTextBox.Text ?? "0", val);
                break;
            case "EQUALS":
                MainTextBox.Text = _calculator.PressEquals(MainTextBox.Text ?? "0");
                break;
            case "CLEAR":
                MainTextBox.Text = _calculator.Clear();
                break;
        }
        
    }

    private void ToggleTheme()
    {
        var app = Application.Current;
        if (app is null) return;
        
        if(app.ActualThemeVariant == ThemeVariant.Dark)
            app.RequestedThemeVariant =  ThemeVariant.Light;
        else if (app.ActualThemeVariant == ThemeVariant.Light)
            app.RequestedThemeVariant = ThemeVariant.Dark;
    }   
}