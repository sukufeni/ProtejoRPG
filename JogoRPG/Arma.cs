namespace JogoRPG
{
     public abstract class Arma 
    {
        protected int dano;
        public int executaAtaque(int vidaAtacante,int forcaFisica,Personagem atacado)
        {
            if (vidaAtacante > 0)
            {
                if (this.dano + forcaFisica <= atacado.Vida)
                    return this.dano + forcaFisica;
                else return atacado.Vida;
            }
            else
            {
                throw new System.Exception("atacante morto!");
            }
            
        }
    }
}
