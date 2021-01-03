using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.DataModels.Characters;

namespace ConsoleDiablo.App.Entities.Characters
{
    public class Druid : Character, IDruid
    {
        public Druid(string name, double strength, double dexterity, double vitality, double energy, CharacterGear gear) 
            : base(name, 
                  strength : 15, 
                  dexterity : 15, 
                  vitality : 20, 
                  energy : 15, 
                  gear : new DruidGear())
        {
        }
    }
}
