using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Immutable;
using System.Globalization;

namespace RenderDemo.Pages;

public partial class FormattedTextPage : UserControl
{
    public FormattedTextPage()
    {
        InitializeComponent();
    }

    public override void Render(DrawingContext context)
    {
        const string testString = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor";

        // Create the initial formatted text string.
        var formattedText = new FormattedText(
            testString,
            CultureInfo.GetCultureInfo("en-us"),
            FlowDirection.LeftToRight,
            new Typeface("Verdana"),
            32,
            Brushes.Black)
        { MaxTextWidth = 300, MaxTextHeight = 240 };

        // Set a maximum width and height. If the text overflows these values, an ellipsis "..." appears.

        // Use a larger font size beginning at the first (zero-based) character and continuing for 5 characters.
        // The font size is calculated in terms of points -- not as device-independent pixels.
        formattedText.SetFontSize(36 * (96.0 / 72.0), 0, 5);

        // Use a Bold font weight beginning at the 6th character and continuing for 11 characters.
        formattedText.SetFontWeight(FontWeight.Bold, 6, 11);

        var gradient = new LinearGradientBrush
        {
            GradientStops =
                new GradientStops { new GradientStop(Colors.Orange, 0), new GradientStop(Colors.Teal, 1) },
            StartPoint = new RelativePoint(0, 0, RelativeUnit.Relative),
            EndPoint = new RelativePoint(0, 1, RelativeUnit.Relative)
        };

        // Use a linear gradient brush beginning at the 6th character and continuing for 11 characters.
        formattedText.SetForegroundBrush(gradient, 6, 11);

        // Use an Italic font style beginning at the 28th character and continuing for 28 characters.
        formattedText.SetFontStyle(FontStyle.Italic, 28, 28);

        context.DrawText(formattedText, new Point(10, 0));

        var geometry = formattedText.BuildGeometry(new Point(10 + formattedText.Width + 10, 0));

        context.DrawGeometry(gradient, null, geometry);

        var highlightGeometry = formattedText.BuildHighlightGeometry(new Point(10 + formattedText.Width + 10, 0));

        context.DrawGeometry(null, new ImmutablePen(gradient.ToImmutable(), 2), highlightGeometry);
    }
}