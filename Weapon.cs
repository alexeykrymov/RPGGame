using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPGGame.Armor;

namespace RPGGame
{
    public class Weapon
    {
        public enum WeaponTypeRange // список дальностит
        {
            Short, // короткое
            Average, // сррденее
            Far // дальнее
        }
        public enum WeaponTypesDamage // список уронов
        {
            SlashingDamage, // рубящее
            StabbingWeapon, // колющее
            BludgeoningDamage // дробящее
        }
        public enum WeaponTypes // create список с типами Weapon
        {
            None, // ничего
            SwordOneHanded, //
            TwoHandedSword, //
            OneHandedSpear, //
            TwoHandedSpear, //
            Mace,           //
            Hammer,         //
            Bow,            //
            Crossbow,       //
            ThrowingAx      //
        }
        public WeaponTypeRange WeaponRange { get; set; }
        public WeaponTypes Type { get; } // свойство типа оружия
        public WeaponTypesDamage TypesDamage { get; private set; } // свойство типа урона
        public int EquippedWeapon { get; private set; } // одеето ли оружие


        public Weapon(WeaponTypeRange weaponRange, WeaponTypes type, WeaponTypesDamage typesDamage) // конструктор, который хранит тип оружия и ее типа урона
        {
            WeaponRange = weaponRange; // дальность оружия
            Type = type; // тип оуржия
            TypesDamage = typesDamage; // прочность тип урона 
        }
       // public Sw
    }
}
