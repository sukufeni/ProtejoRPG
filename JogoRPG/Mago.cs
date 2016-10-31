using System;

namespace JogoRPG
{
    class Mago : Humano
    {
        PocaoVida pocaVida;
        Bio bio;
        Cura magiacura;
        FlamaGelada gelada;
        Intoxicação intoxicacao;
        Tempestade tempestade;
        TridenteSagrado sagrado;
        Cajado cajado;
        private void atributos()
        {
            vida = 2500;
            mana = 100;
            forcaFisica = 40;
            forcaMagica = 100;
            resistArmadura = 30;
            resistMagica = 100;
            agilidade = 40;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/mago.jpg";
        }


        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Mago()
        {
            atributos();
            constroiArmas();
            constroiMagia();
        }
        public override void constroiMagia()
        {
            pocaVida = new PocaoVida();
            bio = new Bio();
            magiacura = new Cura();
            gelada = new FlamaGelada();
            intoxicacao = new Intoxicação();
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            sagrado = new TridenteSagrado();
            cajado= new Cajado();
        }

        public override void ataque(ref int vidaAtacado, string tipoAtaque)
        {
            if (tipoAtaque == "magia") bio.executaMagia(ref vidaAtacado, ref this.mana);
            else sagrado.executaAtaque(ref vidaAtacado);
        }

        public override void cura()
        {
            throw new NotImplementedException();
        }
    }
}
