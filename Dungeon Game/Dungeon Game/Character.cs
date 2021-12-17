using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game
{
    class Character
    {
        int _health;
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int MaxLife { get; set; }
        public int Block { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value <= _health)
                {
                    _health = value;
                }
                else
                {
                    _health = 1;
                }
            }
        }

        public Character(string name, int hitChance, int maxLife,int block, Weapon weapon)
        {
            Name = name;
            HitChance = hitChance;
            MaxLife = maxLife;
            Health = maxLife;
            Block = block;
            EquippedWeapon = weapon;
        }

        public virtual int CalculateDamage()
        {
            Random rand = new Random();
            return rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }

        public virtual int CalculateHitChance()
        {
            return EquippedWeapon.BonusHitChance + HitChance;
        }
    }
}
