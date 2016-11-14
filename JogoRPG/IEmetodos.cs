
namespace JogoRPG
{
    interface IEmetodos
    {
        void ataque(string tipoAtaque, Personagem personagemDefesa);
        int ataqueEspecial(ref int vidaAtacado, string tipoAtaque);
        void defesa(int danoAtaque, Personagem personagemDefesa);
        void somaManaRodada(ref int mana);
         Magia constroiMagia();
         Arma constroiArmas();
    }
}
