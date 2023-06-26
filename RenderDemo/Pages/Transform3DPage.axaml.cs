using Avalonia.Controls;
using RenderDemo.ViewModels;

namespace RenderDemo.Pages;

public partial class Transform3DPage : UserControl
{
    public Transform3DPage()
    {
        InitializeComponent();
        this.DataContext = new Transform3DPageViewModel();
    }
}