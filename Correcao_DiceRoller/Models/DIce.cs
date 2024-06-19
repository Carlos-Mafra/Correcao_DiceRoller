using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao_DiceRoller.Models
{
    public class Dice
    {
        public int QtdLados { get; set; }
        public int NumeroSorteado { get; set; }

        public Dice(int QuantidadeDeLados)
        {
            QtdLados = QuantidadeDeLados;
        }
        public void Roll()
        {
            NumeroSorteado = new Random().Next(QtdLados) + 1;
        }
    }
}