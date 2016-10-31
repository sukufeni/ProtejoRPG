using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    class Zumbi : Inumano
    {
        Intoxicação intoxicacao;
        GarraLetal garraLetal;
        Porrete porrete;
        Cajado cajado;
        private void atributos()
        {
            vida = 2500;
            mana = 20;
            forcaFisica = 40;
            forcaMagica = 20;
            resistArmadura = 80;
            resistMagica = 90;
            agilidade = 20;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/zumbi.jpg";
        }
        
        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Zumbi()
        {
            atributos();
            constroiArmas();
            constroiMagia();
        }

        public override void constroiMagia()
        {
             intoxicacao = new Intoxicação();
        }

        public override void constroiArmas()
        {
            garraLetal = new GarraLetal();
            porrete = new Porrete();
            cajado = new Cajado();
        }

        public override void ataque(ref int vidaAtacado, string tipoAtaque)
        {
            if (tipoAtaque == "magia") intoxicacao.executaMagia(ref vidaAtacado, ref this.mana);
            else porrete.executaAtaque(ref vidaAtacado);
        }

        public override void cura()
        {
            throw new NotImplementedException();
        }
    }
}
