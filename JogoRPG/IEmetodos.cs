using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    interface IEmetodos
    {
        void ataque(int vidaAtacado,string tipoAtaque);
        void ataqueEspecial(int vidaAtacado, string tipoAtaque);
        void cura();
        void rodada(bool magia,ref int mana);
         Magia constroiMagia();
         Arma constroiArmas();
    }
}
