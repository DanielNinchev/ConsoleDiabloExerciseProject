using ConsoleDiablo.App.Entities.Character;
using ConsoleDiablo.App.Entities.Weapons;
using ConsoleDiablo.App.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Items
{
    public class Occulus : Item
    {
        private const int AttackPoints = 5;
        private const int ManaPoints = 120;

        public Occulus() : base(1, ItemDesignedForCharacter.SorceressItem)
        {

        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Damage += AttackPoints;
            character.Mana += ManaPoints;
        }
    }
}
