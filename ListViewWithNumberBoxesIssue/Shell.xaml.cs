using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace ListViewWithNumberBoxesIssue;

public partial class Item(int value, int min) : ObservableObject
{
    [ObservableProperty]
    private int _value = value;

    public int Min { get; } = min;
}

public partial class ShellViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Item> _items =
        [
        new Item(value: 1, min: 1),
        new Item(value: 2, min: 2),
        new Item(value: 3, min: 3),
        ];

    [RelayCommand]
    private void MoveFirstToBottom()
    {
        Items.Move(0, Items.Count - 1);
    }
}

public partial class Shell : Page
{
    public Shell()
    {
        InitializeComponent();
    }

    public ShellViewModel ViewModel { get; } = new();
}
