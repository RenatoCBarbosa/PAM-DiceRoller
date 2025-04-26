
namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        Game jogo = new Game();

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            //Animação();

            /*
            Random random = new Random();
            int sorteio = random.Next(2);
             
            if (sorteio == 0)
            {
                MoedaImage.Source = "cara.png";
            }
            else
            {
                MoedaImage.Source = "coroa.png";
            }
            */

            Dice dado = new Dice();
            DadoImage.Source = dado.Flip() + ".png";

            int sorteio = dado.LadoSorteado == "one" ? 0 : 1; // se lado for == 1, sorteio é igual a 0, caso contrario sorteio é igual a 1 *trocar isso depois

            if (jogo.CheckWinner(SelecaoPicker.SelectedIndex, sorteio))
            {
                DisplayAlert("Parabéns", "Você venceu!", "Ok");
            }
            else
            {
                DisplayAlert("Se ferrou", "Você perdeu!", "Ok");
            }

            PlayerPointLabel.Text = $"Você ganhou {jogo.PlayerPoint} vezes ao todo.";
            StreakLabel.Text = $"Você ganhou {jogo.Streak} vezes em sequencia.";
        }
    }

}
