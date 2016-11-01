using System;

namespace JogoRPG
{
    public class Dragao : Inumano
    {
        HalitoFogo halitoFogo;
        GarraLetal garraLetal;
        private void atributos()
        {
            vida = 3000;
            mana = 40;
            forcaFisica = 100;
            forcaMagica = 20;
            resistArmadura = 100;
            resistMagica = 50;
            agilidade = 80;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/dragao.jpeg";
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Dragao(int jogadores)
        {
            atributos();
            constroiArmas();
            constroiMagia();
        }

        
        public override void constroiMagia()
        {
            halitoFogo = new HalitoFogo();
        }

        public override void constroiArmas()
        {
            garraLetal = new GarraLetal();
        }
        public override void ataque(ref int vidaAtacado, string tipoAtaque)
        {
            if (tipoAtaque == "halito de fogo") halitoFogo.executaMagia(ref vidaAtacado, ref this.mana,this.forcaMagica);
            else garraLetal.executaAtaque(ref vidaAtacado,this.forcaFisica);
        }

        public override void cura()
        {
            throw new NotImplementedException();
        }
    }
}
