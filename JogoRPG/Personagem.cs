using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public abstract class Personagem : IEmetodos
    {
        internal int vida;
        protected int dano;
        internal int mana;
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
            return "vida:" + vida + " - " + "mana: " + mana + "\n" + "força-fisica: " + forcaFisica + " - " + "força-magica: " + forcaMagica + "\n" + "resistencia-armadura: " + resistArmadura + " - " + "resistencia-magica: " + resistMagica;
        }
        public abstract void constroiMagia();
        public abstract void constroiArmas();// mudar para inicializar a arma mais fraca
        public abstract void ataque(string tipoAtaque, Personagem personagemDefesa); // switch para cada ataque utilizando os botoes

        public abstract void cura();// tipos de cura

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
            if (magia != false) mana += 10;  //limite maximo, receber a propria classe?
        }

        public virtual void defesa(int danoAtaque, Personagem personagemDefesa)
        {
            personagemDefesa.defesas.Sort();
            int defesa = defesas[0];
            personagemDefesa.vida -= danoAtaque - defesa;
        }
        public abstract int ataqueEspecial(ref int vidaAtacado, string tipoAtaque);
    }
}
