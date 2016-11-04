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
        protected int forcaMagica;
        protected int resistArmadura;
        protected int resistMagica;
        protected int agilidade;
        protected int fraqueza;
        protected Magia magia;
        protected Arma arma;
        internal string caminhoImagem;
        protected bool ataqueespecial;
        internal List<int> defesas;
        protected List<Magia> Curas;
        public virtual string atributosPersonagem()
        {
            return "vida:" + Vida + " - " + "mana: " + Mana + "\n" + "força-fisica: " + forcaFisica + " - " + "força-magica: " + forcaMagica + "\n" + "resistencia-armadura: " + resistArmadura + " - " + "resistencia-magica: " + resistMagica;
        }
        public abstract void constroiMagia();
        public abstract void constroiArmas();// mudar para inicializar a arma mais fraca
        public abstract void ataque(string tipoAtaque, Personagem personagemDefesa);

        Magia IEmetodos.constroiMagia()
        {
            throw new NotImplementedException();
        }

        Arma IEmetodos.constroiArmas()
        {
            throw new NotImplementedException();
        }

        public void rodada(bool magia, ref int mana)
        {
            if (magia != false) mana += 10;
        }

        public virtual void defesa(int danoAtaque, Personagem personagemDefesa)
        {
            if (danoAtaque <= personagemDefesa.Vida) {
                if(danoAtaque > 0)
                {
                    personagemDefesa.defesas.Sort();
                    int defesa = defesas[0];
                    personagemDefesa.Vida -= danoAtaque - defesa;
                }
            }
            else
            {
                personagemDefesa.Vida = 0;
            }
        }
        public abstract int ataqueEspecial(ref int vidaAtacado, string tipoAtaque);
    }
}
