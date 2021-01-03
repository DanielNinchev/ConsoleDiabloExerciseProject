using ConsoleDiablo.App.Entities.Character;
using ConsoleDiablo.App.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Weapons
{
    public class ShortSword : Item
    {
        private const int AttackPoints = 65;

        public ShortSword() : base(1, ItemDesignedForCharacter.PaladinItem)
        {

        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Damage += AttackPoints;
        }
    }
}
