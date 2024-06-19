using Correcao_DiceRoller.Views;
using Correcao_DiceRoller.Models;
using Correcao_DiceRoller.ViewModels;

namespace Correcao_DiceRoller.Views;

public partial class DiceView : ContentPage
{
    public DiceView()
    {
        InitializeComponent();
        BindingContext = new DiceViewModel();
    }
}