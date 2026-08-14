using Avalonia.Controls;
using Avalonia.Interactivity;

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
}