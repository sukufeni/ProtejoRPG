namespace JogoRPG
{
     public abstract class Arma 
    {
        protected int dano;
        public int executaAtaque(int forcaFisica,Personagem atacado)
        {
            if (this.dano + forcaFisica <= atacado.Vida)
                return this.dano + forcaFisica;
            else return atacado.Vida;
        }
    }
}
