using Avalonia;
using Avalonia.Controls;
using BindingDemo.ViewModels;

namespace BindingDemo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = new MainWindowViewModel();
    }
}