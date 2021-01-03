using ConsoleDiablo.App.Entities.Character;
using ConsoleDiablo.App.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Weapons
{
    public class BroadAxe : Item
    {
        private const int AttackPoints = 85;

        public BroadAxe() : base (name: "Broad Axe", 6, 350, null, 40)
        {

        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Damage += AttackPoints;
        }
    }
}
