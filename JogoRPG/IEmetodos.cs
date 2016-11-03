
namespace JogoRPG
{
    interface IEmetodos
    {
        void ataque(string tipoAtaque, Personagem personagemDefesa);
        int ataqueEspecial(ref int vidaAtacado, string tipoAtaque);
        void cura();
        void defesa(int danoAtaque, Personagem personagemDefesa);
        void rodada(bool magia,ref int mana);
         Magia constroiMagia();
         Arma constroiArmas();
    }
}
