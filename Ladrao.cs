using System;


namespace JogoRPG
{
    class Ladrao : Humano
    {

        Intoxicação intoxicacao;
        Tempestade tempestade;
        EsferaAtaque esfera;
        Porrete porrete;
        Cajado cajado;
        Besta besta;
        
        private void atributos()
        {
            vida = 2800;
            mana = 50;
            forcaFisica = 50;
            forcaMagica = 30;
            resistArmadura = 40;
            resistMagica = 50;
            agilidade = 100;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/goblin.jpg";
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Ladrao(int jogadores) : base(jogadores)
        {
            atributos();
            constroiArmas();
            constroiMagia();
        }

        public override void constroiMagia()
        {
            intoxicacao = new Intoxicação();
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            porrete = new Porrete();
            cajado = new Cajado();
            besta = new Besta();
            esfera = new EsferaAtaque();
        }
        public override void ataque(int vidaAtacado, string tipoAtaque)
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
