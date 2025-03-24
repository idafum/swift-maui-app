
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LotSizeCalculator.ViewModels;

public class LotsResultPopupViewModel : ObservableObject
{
    readonly IPopupService popupService;

    public LotsResultPopupViewModel(IPopupService popupService)
    {
        this.popupService = popupService;
    }
}