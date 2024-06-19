namespace Correcao_DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int numeroSorteado = 0;

        public MainPage()
        {
            InitializeComponent();
            SidesNumbersPicker.SelectedIndex = 0;
        }
        private void RollDiceButton_Clicked(object sender, EventArgs e)
        {
            //Pegar o número selecionado pelo usuário
            //Sortear um numero que seja entre 1 e o numero selecionado
            //Exibir ele na label da interface

            int max = Convert.ToInt32(SidesNumbersPicker.SelectedItem);
            numeroSorteado = new Random().Next(1, max + 1);
            DiceResultLabel.Text = numeroSorteado.ToString();
        }
    }

}