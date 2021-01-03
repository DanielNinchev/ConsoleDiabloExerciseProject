using ConsoleDiablo.App.Entities.Character;
using ConsoleDiablo.App.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ConsoleDiablo.App.Entities.Weapons
{
    public class Scepter : Item
    {
        private const int AttackPoints = 35;
        private const int ManaPoints = 50;

        public Scepter() : base(1, ItemDesignedForCharacter.PaladinItem)
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
