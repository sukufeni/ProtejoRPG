﻿namespace JogoRPG
{
    public abstract class Magia
    {
        protected int valorMagia;
        public int gastoMana { get; protected set; }
        public virtual int executaMagia(int vidaAtacante,ref int mana, int forcaMagica, Personagem atacado)
        {

            if (vidaAtacante > 0)
            {
                if (mana >= gastoMana && atacado.Vida >= (valorMagia + forcaMagica))
                {
                    mana -= gastoMana;
                    return valorMagia + forcaMagica;
                }
                else
                {
                    mana = 0;
                    return atacado.Vida;
                }
            }
            else
            {
                throw new System.Exception("atacante morto!");
            }
        }
        public virtual int executaCura(int vidaAtacante,ref int mana, int forcaMagica, Personagem vida,int vidaMaxima)
        {
            if (valorMagia + forcaMagica +vida.Vida <=vidaMaxima && vidaAtacante > 0)
            {
                mana -= gastoMana;
                return valorMagia + forcaMagica;
            }
            else
            {
                throw new System.Exception("magia irá exceder a vida maxima!");
            }
        }
    }
}
