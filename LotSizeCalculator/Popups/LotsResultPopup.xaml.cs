
using CommunityToolkit.Maui.Views;
using LotSizeCalculator.ViewModels;

namespace LotSizeCalculator.Popups;

public partial class LotsResultPopup : Popup
{
    public LotsResultPopup(LotsResultPopupViewModel lotsResultPopupViewModel)
    {
        InitializeComponent();
        BindingContext = lotsResultPopupViewModel;
    }
}