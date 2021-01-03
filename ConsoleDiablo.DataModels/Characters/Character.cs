using ConsoleDiablo.App.Entities.Contracts;
using System;

namespace ConsoleDiablo.DataModels.Characters
{
	public abstract class Character : ICharacter
	{
		private string name;
		private double strength;
		private double damage;
		private double dexterity;
		private double defense;
		private double vitality;
		private double baseLife;
		private double life;
		private double energy;
		private double baseMana;
		private double mana;
		private double lifeRegenerationMultiplier;
		private double manaRegenerationMultiplier;
		private double experience;
		private int level;
		private double fireResistance;
		private double lightningResistance;
		private double coldResistance;
		private double poisonResistance;
		private ICharacterGear gear;
		private IInventory inventory;
		private IStash stash;
		private double moneyBalance;

		protected Character(
			string name,
			double strength,
			double dexterity,
			double vitality,
			double energy,
			CharacterGear gear)
		{
			this.Name = name;
			this.strength = strength;
			this.Damage = strength * 0.5;
			this.dexterity = dexterity;
			this.defense = dexterity * 0.5;
			this.vitality = vitality;
			this.BaseLife = vitality * 0.5;
			this.Life = life;
			this.LifeRegenerationMultiplier = vitality * 0.01;
			this.energy = energy;
			this.BaseMana = energy * 0.5;
			this.Mana = mana;
			this.ManaRegenerationMultiplier = energy * 0.01;
			this.CharacterGear = gear;
			this.moneyBalance = 0;
			this.experience = 0;
			this.level = (int)Math.Floor(experience / 1000);
			this.fireResistance = 0;
			this.lightningResistance = 0;
			this.coldResistance = 0;
			this.poisonResistance = 0;
		}

		public double PoisonResistance
		{
			get { return poisonResistance; }
			set { poisonResistance = value; }
		}

		public double ColdResistance
		{
			get { return coldResistance; }
			set { coldResistance = value; }
		}

		public double LightningResistance
		{
			get { return lightningResistance; }
			set { lightningResistance = value; }
		}

		public double FireResistance
		{
			get { return fireResistance; }
			set { fireResistance = value; }
		}

		public double MoneyBalance
		{
			get { return moneyBalance; }
			set { moneyBalance = value; }
		}

		public double Defense
		{
			get { return defense; }
			set { defense = value; }
		}

		public int Level
		{
			get { return level; }
			set { level = value; }
		}

		public double Experience
		{
			get { return experience; }
			set { experience = value; }
		}

		public double Energy
		{
			get { return energy; }
			set { energy = value; }
		}

		public double Vitality
		{
			get { return vitality; }
			set { vitality = value; }
		}

		public double Dexterity
		{
			get { return dexterity; }
			set { dexterity = value; }
		}

		public double Strength
		{
			get { return strength; }
			set { strength = value; }
		}

		public double Damage
		{
			get { return damage; }
			set { damage = value; }
		}

		public double ManaRegenerationMultiplier
		{
			get { return manaRegenerationMultiplier; }
			set { manaRegenerationMultiplier = value; }
		}
		public CharacterGear CharacterGear { get; }

		public double LifeRegenerationMultiplier
		{
			get { return lifeRegenerationMultiplier; }
			set { lifeRegenerationMultiplier = value; }
		}

		public double Mana
		{
			get { return mana; }
			set { mana = value; }
		}

		public double BaseMana
		{
			get { return baseMana; }
			set { baseMana = value; }
		}

		public double Life
		{
			get { return life; }
			set { life = value; }
		}

		public double BaseLife
		{
			get { return baseLife; }
			set { baseLife = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public bool IsAlive { get; set; } = true;

		public CharacterGear Gear => this.CharacterGear;

        protected void EnsureAlive()
		{
			if (!IsAlive)
			{
				throw new InvalidOperationException("The character must be alive to perform this action.");
			}
		}

		public void UseItemBy(Item item, Character character)
		{
			item.AffectCharacter(character);
		}

		public void CollectItemInGear(Item item)
		{
			this.CharacterGear.AddItemToGear(item);
		}

		public void Attack(Character character)
		{
			EnsureAlive();

			if (character == this)
			{
				throw new InvalidOperationException("The characters cannot hurt themselves!");
			}

			character.TakeDamage(this.Damage);
		}

		public void TakeDamage (double takenDamage)
		{
			EnsureAlive();

			this.Life = Math.Max(0, life - takenDamage);

			if (life == 0)
			{
				IsAlive = false;
			}
		}

		public void Recover()
		{
			EnsureAlive();

			this.Life = Math.Min(Life + BaseLife * LifeRegenerationMultiplier, BaseLife);
			this.Mana = Math.Min(Mana + BaseMana * ManaRegenerationMultiplier, BaseMana);
		}

		public override string ToString()
		{
			const string format = "{0} - Life: {2}/{3}, Mana: {4}/{5}, Damage: {6}, Status: {7}";

			var result = string.Format(format,
				Name,
				Level,
				Life,
				BaseLife,
				Mana,
				BaseMana,
				Damage,
				IsAlive ? "Alive" : "Dead");

			return result;
		}
	}
}
