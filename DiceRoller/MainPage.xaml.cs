
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

            int sorteio = 0;
            switch (dado.LadoSorteado)
            {
                case "dice_one":
                    sorteio = 1;
                    break;
                case "dice_two":
                    sorteio = 2;
                    break;
                case "dice_three":
                    sorteio = 3;
                    break;
                case "dice_four":
                    sorteio = 4;
                    break;
                case "dice_five":
                    sorteio = 5;
                    break;
                case "dice_six":
                    sorteio = 6;
                    break;
                default:
                    sorteio = 0;
                    break;
            }
            sorteio -= 1;

            if (jogo.CheckWinner(SelecaoPicker.SelectedIndex, sorteio) && jogo.SomaOposto < 25)
            {
                DisplayAlert("Parabéns", "Você venceu!", "Ok");
            }
            else if (jogo.SomaOposto >= 25)
            {
                DisplayAlert("Acabou a diversão", "Você passou do limite!", "Ok");
            }
            else
            {
                DisplayAlert("Se ferrou!", "Você perdeu!", "Ok");
            }

            jogo.SomarOposto(sorteio);
            PlayerPointLabel.Text = $"Você ganhou {jogo.PlayerPoint} vezes ao todo.";
            StreakLabel.Text = $"Você ganhou {jogo.Streak} vezes em sequencia.";
            SomaLabel.Text = $"Soma total do lado oposto {jogo.SomaOposto}";
            
        }
    }

}
