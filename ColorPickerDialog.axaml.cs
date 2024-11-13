using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace SegmentDisplayTool;

public partial class ColorPickerDialog : Window
{
    public bool result = false;
    public ColorPickerDialog()
    {
        InitializeComponent();
    }

    private void Confirm(object sender, RoutedEventArgs e)
    {
        result = true;
        this.Close();
    }
}