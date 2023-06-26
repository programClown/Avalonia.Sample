using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RenderDemo.Pages;

public partial class CustomAnimatorPage : UserControl
{
    public CustomAnimatorPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}