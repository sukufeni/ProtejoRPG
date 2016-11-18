using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public abstract class Personagem : IEmetodos
    {
        internal int Vida;
        protected int dano;
        public int Mana;
        protected int forcaFisica;
        private int vidaMaxima;
        private int manaMaxima;
        protected int forcaMagica;
        protected int resistArmadura;
        protected int resistMagica;
        protected int agilidade;
        protected int fraqueza;
        protected Magia magia;
        protected Arma arma;
        internal string caminhoImagem;
        internal List<int> defesas;
        protected List<Magia> Curas;
        protected List<string> acoes;
        Random r = new Random();

        public List<string> Acoes
        {
            get
            {
                return acoes;
            }
        }
        public void setVidaManaMaxima()
        {
            this.vidaMaxima = Vida;
            this.manaMaxima = Mana;
        }
        public int getVidaMaxima()
        {
            return this.vidaMaxima;
        }
        public int getManaMaxma()
        {
            return this.manaMaxima;
        }
        public virtual string atributosPersonagem()
        {
            return "vida:" + Vida + " - " + "mana: " + Mana + "\n" + "força-fisica: " + forcaFisica + " - " + "força-magica: " + forcaMagica + "\n" + "resistencia-armadura: " + resistArmadura + " - " + "resistencia-magica: " + resistMagica;
        }
        public abstract void constroiMagia();
        public abstract void constroiArmas();// mudar para inicializar a arma mais fraca
        public abstract void ataque(string tipoAtaque, Personagem personagemDefesa);

        Arma IEmetodos.constroiArmas()
        {
            throw new NotImplementedException();
        }
        Magia IEmetodos.constroiMagia()
        {
            throw new NotImplementedException();
        }

        public void somaManaRodada(ref int mana)
        {
            if(mana+10<=getManaMaxma())mana += 10;
            else mana += getManaMaxma() - mana;
        }
        public virtual void defesa(int danoAtaque, Personagem personagemDefesa)
        {
            try
            {
                if (danoAtaque > 0)
                {
                    if (danoAtaque <= personagemDefesa.Vida)
                    {
                        int defesa = r.Next(personagemDefesa.defesas.Count);
                        personagemDefesa.Vida -= danoAtaque - defesa;
                    }
                    else
                    {
                        personagemDefesa.Vida = 0;
                    }
                }
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("erro ao defender!", e);
            }
        }

        public void ataqueEspecial(Personagem atacado)
        {
            if (this.Vida > 0)
            {
                if (this.forcaMagica*forcaFisica <= atacado.Vida)
                {
                    atacado.defesa(this.forcaFisica * forcaMagica, atacado);
                }
                else
                {
                    atacado.defesa(atacado.Vida, atacado);
                }
            }
            else
            {
                throw new Exception("erro ao fazer o ataque especial!");
            }
                
        }
    }
}
