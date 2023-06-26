using Avalonia.Controls;
using RenderDemo.ViewModels;

namespace RenderDemo.Pages;

public partial class TransitionsPage : UserControl
{
    public TransitionsPage()
    {
        InitializeComponent();
        this.DataContext = new AnimationsPageViewModel();
    }
}