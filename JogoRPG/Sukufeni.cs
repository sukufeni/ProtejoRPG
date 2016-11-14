using System;

namespace JogoRPG
{
    class Sukufeni : Humano, ICura
    {

        Intoxicacao intoxicacao;
        GarraLetal garra;
        Besta besta;
        PocaoVida vida;

        public Sukufeni()
        {
            this.Vida = 10000;
            this.forcaMagica = 10000;
            this.forcaFisica = 10000;
            this.Mana = 10000;
            this.resistArmadura = 10000;
            this.resistMagica = 10000;
        }

        public override void ataque(string tipoAtaque, Personagem personagemDefesa)
        {
            switch (tipoAtaque)
            {
                case "Besta": besta.executaAtaque(this.forcaFisica, personagemDefesa);
                    break;
                case "GarraLetal": garra.executaAtaque(this.forcaFisica, personagemDefesa);
                    break;
                default:intoxicacao.executaMagia(ref this.Mana, this.forcaMagica, personagemDefesa);
                    break;
            }
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }   
        public override void constroiArmas()
        {
            besta = new Besta();
            garra = new GarraLetal();
        }

        public override void constroiMagia()
        {
            intoxicacao = new Intoxicacao();
            vida = new PocaoVida();
        }

        public void cura(Magia e)
        {
            this.Vida = e.executaCura(ref this.Mana, this.forcaMagica,this,2500);
        }
    }
}
