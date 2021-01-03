using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.DataModels.Characters;

namespace ConsoleDiablo.App.Entities.Characters
{
    public class Necromancer : Character, INecromancer
    {
        public Necromancer(string name, double strength, double dexterity, double vitality, double energy, CharacterGear gear) 
            : base(name,
                  strength : 10,
                  dexterity : 10,
                  vitality : 15,
                  energy : 30,
                  gear : new NecromancerGear())
        {
        }
    }
}
