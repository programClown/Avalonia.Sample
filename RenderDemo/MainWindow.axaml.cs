using Avalonia.Controls;
using Avalonia.Rendering;
using MiniMvvm;
using RenderDemo.ViewModels;
using System;
using System.Linq.Expressions;

namespace RenderDemo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var vm = new MainWindowViewModel();

        void BindOverlay(Expression<Func<MainWindowViewModel, bool>> expr, RendererDebugOverlays overlay)
                => vm.WhenAnyValue(expr).Subscribe(x =>
                {
                    var diagnostics = RendererDiagnostics;
                    diagnostics.DebugOverlays = x ?
                        diagnostics.DebugOverlays | overlay :
                        diagnostics.DebugOverlays & ~overlay;
                });

        BindOverlay(x => x.DrawDirtyRects, RendererDebugOverlays.DirtyRects);
        BindOverlay(x => x.DrawFps, RendererDebugOverlays.Fps);
        BindOverlay(x => x.DrawLayoutTimeGraph, RendererDebugOverlays.LayoutTimeGraph);
        BindOverlay(x => x.DrawRenderTimeGraph, RendererDebugOverlays.RenderTimeGraph);

        DataContext = vm;
    }
}