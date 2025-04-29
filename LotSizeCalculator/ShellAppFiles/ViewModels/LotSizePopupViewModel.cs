/*
    This controls the view on the LotSizePopup
*/

using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LotSizeCalculator.ShellAppFiles.ViewModels;

public partial class LotSizePopupViewModel : ObservableObject
{
    [ObservableProperty]
    string name = "";
    readonly IPopupService popupService;
    public LotSizePopupViewModel(IPopupService popupService)
    {
        this.popupService = popupService;
    }

    void OnCancel()
    {

    }

    [RelayCommand(CanExecute = nameof(CanSave))]
    void OnSave()
    {

    }

    bool CanSave() => string.IsNullOrWhiteSpace(Name) is false;
}