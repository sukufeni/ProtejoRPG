using System;

namespace JogoRPG
{
    class Paladino : Humano
    {
        PocaoVida magiaVida;
        FlamaGelada flamaGelada;
        Tempestade tempestade;
        TridenteSagrado tridenteSagrado;
        Besta besta;
        private void atributos()
        {
            vida = 3200;
            mana = 80;
            forcaFisica = 60;
            forcaMagica = 60;
            resistArmadura = 60;
            resistMagica = 60;
            agilidade = 60;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/paladin.jpg";
        }


        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Paladino(int jogadores) : base(jogadores)
        {
            atributos();

            constroiArmas();
            constroiMagia();
        }

      
        public override void constroiMagia()
        {
            magiaVida = new PocaoVida();
            flamaGelada = new FlamaGelada();
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            tridenteSagrado = new TridenteSagrado();
            besta = new Besta();
        }
        public override void ataque(int vidaAtacado, string tipoAtaque)
        {

            if (tipoAtaque == "magia") flamaGelada.executaMagia(ref vidaAtacado, ref this.mana);
            else besta.executaAtaque(ref vidaAtacado);
        }

        public override void cura()
        {
            magiaVida.executaMagia(ref this.vida, ref this.mana);
        }
    }
}
