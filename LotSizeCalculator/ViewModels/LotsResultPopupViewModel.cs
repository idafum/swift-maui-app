
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LotSizeCalculator.ViewModels;

public partial class LotsResultPopupViewModel : ObservableObject
{
    readonly IPopupService popupService;

    [ObservableProperty]
    double lotSize;

    public LotsResultPopupViewModel(IPopupService popupService)
    {
        this.popupService = popupService;
    }
}