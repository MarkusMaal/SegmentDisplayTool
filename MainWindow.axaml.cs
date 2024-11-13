using System.Collections.Generic;
using System.Linq;
using System.Text;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace SegmentDisplayTool;

public partial class MainWindow : Window
{
    private Color color = Colors.Red;
    private Color color2 = Colors.DimGray;
    private bool[] data = [false, false, false, false, false, false, false, false];
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnLoad(object? sender, RoutedEventArgs e)
    {
        
    }

    private void BootstrapDisplayData(object? sender, RoutedEventArgs e)
    {
        DisplayData();
        DigitDisplay.Width = DpIncludeCheck.IsChecked ?? false ? 200 : 180;
        DotSegment.IsVisible = DpIncludeCheck.IsChecked ?? false;
    }
    
    private void DisplayData()
    {
        var chars = new List<char>();
        if ((DpIncludeCheck.IsChecked ?? false) && (DpFirstCheck.IsChecked ?? false))
        {
            chars.Add(data[0] ? '1' : '0');
        }
        for (var i = 1; i < data.Length; i++)
        {
            chars.Add(data[i] ? '1' : '0');
        }
        if ((DpIncludeCheck.IsChecked ?? false) && (!DpFirstCheck.IsChecked ?? true))
        {
            chars.Add(data[0] ? '1' : '0');
        }
        var separator = DataSeparator.Text ?? "";
        if (separator == "<none>")
        {
            separator = "";
        }
        var display = string.Join(separator, chars.ToArray());
        DataDisplay.Content = display;
    }

    private void ToggleSegment(object? sender, PointerPressedEventArgs e)
    {
        switch (sender)
        {
            case Polygon polygon:
                var segmentId = int.Parse(polygon.Name?.Replace("Segment", "") ?? string.Empty);
                if (data[segmentId])
                {
                    polygon.Fill = new SolidColorBrush(color2);
                }
                else
                {
                    polygon.Fill = new SolidColorBrush(color);
                }
                data[segmentId] = !data[segmentId];
                break;
            case Ellipse ellipse:
                if (data[0])
                {
                    ellipse.Fill = new SolidColorBrush(color2);
                }
                else
                {
                    ellipse.Fill = new SolidColorBrush(color);
                }
                data[0] = !data[0];
                break;
        }
        DisplayData();
    }

    private void CopyData(object? sender, RoutedEventArgs e)
    {
        if (DataDisplay.Content != null) Clipboard?.SetTextAsync(DataDisplay.Content.ToString());
    }

    private void DataSeparator_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        DisplayData();
    }

    private void ChangeDisplayTechnology(object? sender, SelectionChangedEventArgs e)
    {
        if (sender is ComboBox comboBox && DigitDisplay != null)
        {
            LightColor.IsEnabled = false;
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    DigitDisplay.Background = Brushes.Black;
                    color = Colors.Red;
                    color2 = Colors.DimGray;
                    LightColor.IsEnabled = true;
                    break;
                case 1:
                    DigitDisplay.Background = Brushes.PaleGreen;
                    color = Colors.Black;
                    color2 = Colors.DarkSeaGreen;
                    break;
                case 2:
                    DigitDisplay.Background = Brushes.WhiteSmoke;
                    color = Colors.Black;
                    color2 = Colors.LightGray;
                    break;
            }
            ReloadColors();
        }
    }

    private void ReloadColors()
    {
        DotSegment.Fill = new SolidColorBrush(data[0] ? color : color2);
        Segment1.Fill = new SolidColorBrush(data[1] ? color : color2);
        Segment2.Fill = new SolidColorBrush(data[2] ? color : color2);
        Segment3.Fill = new SolidColorBrush(data[3] ? color : color2);
        Segment4.Fill = new SolidColorBrush(data[4] ? color : color2);
        Segment5.Fill = new SolidColorBrush(data[5] ? color : color2);
        Segment6.Fill = new SolidColorBrush(data[6] ? color : color2);
        Segment7.Fill = new SolidColorBrush(data[7] ? color : color2);
    }

    private async void ChangeColor(object? sender, RoutedEventArgs e)
    {
        ColorPickerDialog cpd = new();
        await cpd.ShowDialog(this);
        if (!cpd.result) return;
        color = cpd.Color.Color;
        ReloadColors();
    }

    private async void DecodeByte(object? sender, RoutedEventArgs e)
    {
        InputBox input = new()
        {
            Text =
            {
                Content = "Enter a byte to decode:"
            },
            Title = "Decode a byte"
        };
        await input.ShowDialog(this);
        if (!input.result) return;
        var chars = input.InputTxt.Text?.ToCharArray();
        var i = 0;
        foreach (var c in chars ?? [])
        {
            if (i >= data.Length) break;
            data[i] = c == '1';
            i++;
        }
        DisplayData();
        ReloadColors();
    }
}