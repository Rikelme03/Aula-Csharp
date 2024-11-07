
namespace RPGPOO.Personagens
{
    public class Personagens
    {
        public string Nome;

        public int Idade;

        public string Ia;

        public string Armadura;

        public void Atacar(){
        Console.WriteLine($"\r\nO(a) {Nome} Pega ele ahhhhhhhhhhhhhhhhh!  😈");

        }
        public void Defender(){

        Console.WriteLine($"O(a) {Nome} Coreee Ahhhhhhhhhhhhhh! 🥵");
        }
        public void RestaurarArmadura(){

        Console.WriteLine($"O(a) {Nome} Parabens sua Armadura esta 100%! 😒");
        }
    }

   
}