using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace CalculatorAvalonia
{
    public partial class MainWindow : Window
    {
        private double _firstNumber = 0;
        private double _secondNumber = 0;
        private string _operation = "";
        private bool _isOperationPressed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnNumberClick(object? sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Content is string number)
            {
                if (_isOperationPressed)
                {
                    DisplayTextBox.Text = "";
                    _isOperationPressed = false;
                }

                if (DisplayTextBox.Text == "0")
                {
                    DisplayTextBox.Text = number;
                }
                else
                {
                    DisplayTextBox.Text += number;
                }
            }
        }

        private void OnOperationClick(object? sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Content is string operation)
            {
                if (!string.IsNullOrEmpty(_operation) && !_isOperationPressed)
                {
                    OnEqualsClick(sender, e);
                }

                _firstNumber = double.Parse(DisplayTextBox.Text);
                _operation = operation;
                _isOperationPressed = true;
            }
        }

        private void OnEqualsClick(object? sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
                return;

            _secondNumber = double.Parse(DisplayTextBox.Text);
            double result = 0;

            switch (_operation)
            {
                case "+":
                    result = _firstNumber + _secondNumber;
                    break;
                case "−":
                    result = _firstNumber - _secondNumber;
                    break;
                case "×":
                    result = _firstNumber * _secondNumber;
                    break;
                case "÷":
                    if (_secondNumber == 0)
                    {
                        var dialog = new Window
                        {
                            Title = "錯誤",
                            Content = new TextBlock { Text = "不能除以零！", Margin = new Avalonia.Thickness(20) },
                            Width = 200,
                            Height = 100,
                            WindowStartupLocation = WindowStartupLocation.CenterOwner
                        };
                        dialog.ShowDialog(this);
                        DisplayTextBox.Text = "0";
                        _operation = "";
                        return;
                    }
                    result = _firstNumber / _secondNumber;
                    break;
            }

            DisplayTextBox.Text = result.ToString();
            _operation = "";
            _isOperationPressed = false;
        }

        private void OnClearClick(object? sender, RoutedEventArgs e)
        {
            DisplayTextBox.Text = "0";
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = "";
            _isOperationPressed = false;
        }

        private void OnDecimalClick(object? sender, RoutedEventArgs e)
        {
            if (_isOperationPressed)
            {
                DisplayTextBox.Text = "0";
                _isOperationPressed = false;
            }

            if (!DisplayTextBox.Text.Contains("."))
            {
                DisplayTextBox.Text += ".";
            }
        }
    }
}
