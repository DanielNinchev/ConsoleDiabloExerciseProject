using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.DataModels.Characters;

namespace ConsoleDiablo.App.Entities.Characters
{
    public class Amazon : Character, IAmazon
    {
        public Amazon(string name, double strength, double dexterity, double vitality, double energy, CharacterGear gear) 
            : base(name, 
                  strength : 15, 
                  dexterity : 20, 
                  vitality : 20, 
                  energy : 10, 
                  gear : new AmazonGear())
        {
        }
    }
}
