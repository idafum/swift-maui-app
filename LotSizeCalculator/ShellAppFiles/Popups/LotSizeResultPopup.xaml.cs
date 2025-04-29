/*
    The code behind the LotSizeResultPopup
*/

using CommunityToolkit.Maui.Views;
using LotSizeCalculator.ShellAppFiles.ViewModels;

namespace LotSizeCalculator.ShellAppFiles.Popups;

public partial class LotSizeResultPopup : Popup
{
    public LotSizeResultPopup(LotSizePopupViewModel lotSizePopupViewModel)
    {
        InitializeComponent();
        BindingContext = lotSizePopupViewModel;
    }
}