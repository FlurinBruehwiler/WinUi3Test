using Microsoft.UI.Xaml.Controls;

using WinUiTest2.ViewModels;

namespace WinUiTest2.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
