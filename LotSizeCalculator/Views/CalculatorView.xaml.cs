
/*
    This is the Page behind the CalculatorView.xaml. 
*/
using LotSizeCalculator.ViewModels;

namespace LotSizeCalculator.Views;

public partial class CalculatorView : ContentPage
{
    public CalculatorView()
    {
        InitializeComponent();
        BindingContext = new CalculatorViewModel();
    }
}