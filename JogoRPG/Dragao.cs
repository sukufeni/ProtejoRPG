using System;
using System.Collections.Generic;

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
            this.defesas = new List<int>();
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            defesas.Add(resistArmadura);
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/dragao.jpeg";
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Dragao()
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
        public override void ataque(string tipoAtaque, Personagem personagemdefesa)
        {
            if (tipoAtaque == "halito de fogo") personagemdefesa.defesa(halitoFogo.executaMagia(ref this.mana,this.forcaMagica),personagemdefesa);
            else personagemdefesa.defesa(garraLetal.executaAtaque(this.forcaFisica),personagemdefesa);
        }

        public override void cura()
        {
            throw new NotImplementedException();
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
