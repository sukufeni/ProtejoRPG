using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    public class Arma
    {
        protected int dano;

        public void executaAtaque(ref int vidaAtacado)
        {
            vidaAtacado -= this.dano;
        }
    }
}
