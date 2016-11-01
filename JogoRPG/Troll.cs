using System;

namespace JogoRPG
{
    public class Troll : Inumano
    {
        Intoxicação intoxicacao;
        Porrete porrete;
        Cajado cajado;
        private void atributos()
        {
            vida = 2800;
            mana = 20;
            forcaFisica = 100;
            forcaMagica = 20;
            resistArmadura = 100;
            resistMagica = 20;
            agilidade = 20;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/troll.jpg";
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Troll()
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
             porrete = new Porrete();
             cajado = new Cajado();
        }

        public override void ataque(ref int vidaAtacado, string tipoAtaque)
        {
            switch (tipoAtaque)
            {
                case "intoxicação": intoxicacao.executaMagia(ref vidaAtacado, ref this.mana, this.forcaMagica);
                    break;
                case "porrete": porrete.executaAtaque(ref vidaAtacado, this.forcaFisica);
                    break;
                case "cajado": cajado.executaAtaque(ref vidaAtacado, this.forcaFisica);
                    break;
            }
            
        }

        public override void cura()
        {
            throw new NotImplementedException();
        }
    }
}
