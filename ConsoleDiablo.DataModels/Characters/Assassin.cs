using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.DataModels.Characters;

namespace ConsoleDiablo.App.Entities.Characters
{
    public class Assassin : Character, IAssassin
    {
        public Assassin(string name, double strength, double dexterity, double vitality, double energy, CharacterGear gear) 
            : base(name, 
                  strength = 15, 
                  dexterity = 25, 
                  vitality = 15, 
                  energy = 10, 
                  gear : new AssassinGear())
        {
        }
    }
}
