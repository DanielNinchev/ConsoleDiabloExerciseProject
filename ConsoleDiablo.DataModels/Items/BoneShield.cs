using ConsoleDiablo.App.Entities.Weapons;
using ConsoleDiablo.App.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleDiablo.App.Entities.Character;

namespace ConsoleDiablo.App.Entities.Items
{
    public class BoneShield : Item
    {
        private const int ManaPoints = 20;

        public BoneShield() : base(1, ItemDesignedForCharacter.SorceressItem)
        {

        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Mana += ManaPoints;
        }
    }
}
