using Avalonia.Controls;
using RenderDemo.ViewModels;

namespace RenderDemo.Pages;

public partial class AnimationsPage : UserControl
{
    public AnimationsPage()
    {
        InitializeComponent();
        this.DataContext = new AnimationsPageViewModel();
    }
}