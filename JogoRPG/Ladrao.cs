using System;

namespace JogoRPG
{
   public  class Ladrao : Humano
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

        public Ladrao()
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
        public override void ataque(ref int vidaAtacado, string tipoAtaque)
        {
            switch (tipoAtaque)
            {
                case "intoxicação": intoxicacao.executaMagia(ref vidaAtacado, ref this.mana, this.forcaMagica);
                    break;
                case "tempestade": tempestade.executaMagia(ref vidaAtacado, ref this.mana,this.forcaMagica);
                    break;
                case "porrete": porrete.executaAtaque(ref vidaAtacado, this.forcaFisica);
                    break;
                case "cajado": cajado.executaAtaque(ref vidaAtacado, this.forcaFisica);
                    break;
                case "besta": besta.executaAtaque(ref vidaAtacado, this.forcaFisica);
                    break;
                case "esfera": esfera.executaAtaque(ref vidaAtacado,this.forcaFisica);
                    break;
            }
        }

        public override void cura()
        {
            throw new NotImplementedException();
        }
    }
}
