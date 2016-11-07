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
            Vida = 3000;
            Mana = 40;
            forcaFisica = 100;
            forcaMagica = 20;
            resistArmadura = 100;
            resistMagica = 50;
            agilidade = 80;
            this.defesas = new List<int>();
            this.ataques = new List<string>();
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
            ataques.Add(halitoFogo.ToString());
            ataques.Add(garraLetal.ToString());
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
            if (tipoAtaque == "HalitoFogo") personagemdefesa.defesa(halitoFogo.executaMagia(ref this.Mana,this.forcaMagica,personagemdefesa),personagemdefesa);
            else personagemdefesa.defesa(garraLetal.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
