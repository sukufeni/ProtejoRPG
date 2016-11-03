using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Animal : Inumano
    {
        Bio bio;
        GarraLetal garraLetal;
        

        private void atributos()
        {

            vida = 3200;
            mana = 30;
            forcaFisica = 80;
            forcaMagica = 20;
            resistArmadura = 90;
            agilidade = 50;
            resistMagica = 20;
            this.defesas = new List<int>();
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            defesas.Add(resistArmadura);
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/animal.png";
        }
        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }
        public Animal()
        {
            atributos();
            constroiArmas();
            constroiMagia();
        }

        public override void constroiMagia()
        {
            bio = new Bio();
        }

        public override void constroiArmas()
        {
            garraLetal = new GarraLetal();
        }
        
        public override void ataque(string tipoAtaque, Personagem personagemdefesa)
        {
            if (tipoAtaque == "bio") personagemdefesa.defesa(bio.executaMagia(ref this.mana, this.forcaMagica), personagemdefesa);
            else personagemdefesa.defesa(garraLetal.executaAtaque(this.forcaFisica),personagemdefesa);
        }
        public override void cura()
        {
            throw new NotImplementedException();
        }

        public override void defesa(int danoAtaque, Personagem personagemDefesa)
        {
            personagemDefesa.defesas.Sort();
            int defesa = defesas[0];
            personagemDefesa.vida -= danoAtaque - defesa / 100;
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
