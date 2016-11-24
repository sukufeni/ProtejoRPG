
namespace JogoRPG
{
    interface IEmetodos
    {
        void ataque(int ataque, Personagem personagemDefesa, object tipoAtaque);
        void ataqueEspecial(Personagem defesa);
        void defesa(int danoAtaque, Personagem personagemDefesa);
        void somaManaRodada(ref int mana);
         Magia constroiMagia();
         Arma constroiArmas();
    }
}
