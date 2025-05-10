using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Dice
    {
        private string ladoSorteado;
        private string ladoParaCima { get; set; }
        private string ladoParaBaixo {  get; set; }

        public string LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        public Dice()
        {
        }

        public string Flip()
        {
            Random random = new Random();
            int ladoDado = random.Next(6);
            ladoDado += 1;
            if (ladoDado == 1)
            {
                LadoSorteado = "dice_one";
            }
            else if (ladoDado == 2)
            {
                LadoSorteado = "dice_two";
            }
            else if (ladoDado == 3)
            {
                LadoSorteado = "dice_three";
            }
            else if (ladoDado == 4)
            {
                LadoSorteado = "dice_four";
            }
            else if (ladoDado == 5)
            {
                LadoSorteado = "dice_five";
            }
            else if (ladoDado == 6)
            {
                LadoSorteado = "dice_six";
            }
            //   LadoSorteado = random.Next(2) == 0 ? "Cara" : "Coroa";

            return (LadoSorteado);
        }
    }
}
