using System;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [RelayCommand]
    private void SelectionChanged()
    {
        Console.WriteLine(nameof(SelectionChangedCommand) + " Executing!!!");
    }

    [RelayCommand]
    private void PointerMoved(PointerEventArgs e)
    {
        var p = e.GetPosition(((IClassicDesktopStyleApplicationLifetime)App.Current.ApplicationLifetime).MainWindow);
        Console.WriteLine($"{nameof(PointerMovedCommand)} Executing...{p.X},{p.Y}");
    }
}