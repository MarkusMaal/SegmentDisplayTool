using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace SegmentDisplayTool;

public partial class InputBox : Window
{
    internal bool result = false;
    public InputBox()
    {
        InitializeComponent();
    }

    private void Window_Loaded(object? sender, RoutedEventArgs e)
    {
        InputTxt.Text = "";
    }

    private void Dialog_OK(object? sender, RoutedEventArgs? e)
    {
        result = true;
        this.Close();
    }

    private void TextBox_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            Dialog_OK(sender, null);
        }
    }
}