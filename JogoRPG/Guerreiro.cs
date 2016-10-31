using System;


namespace JogoRPG
{
   public class Guerreiro : Humano
    {
        Tempestade tempestade;
        EspadaBarroca espada;
        Porrete porrete;

        private void atributos()
        {
            vida = 4000;
            mana = 30;
            forcaFisica = 100;
            forcaMagica = 20;
            resistArmadura = 80;
            resistMagica = 20;
            agilidade = 50;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/guerreiro.jpg";
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Guerreiro()
        {
            atributos();
            constroiArmas();
            constroiMagia();
        }

        public override void constroiMagia()
        {
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            espada = new EspadaBarroca();
            porrete= new Porrete();
        }

        public  override void ataque(ref int vidaAtacado, string tipoAtaque)
        {
            if (tipoAtaque == "magia") tempestade.executaMagia(ref vidaAtacado, ref this.mana);
            //else porrete.executaAtaque(ref vidaAtacado)||espada.executaAtaque(ref vidaAtacado);
        }

        public override void cura()
        {
            throw new NotImplementedException();
        }
    }
}
