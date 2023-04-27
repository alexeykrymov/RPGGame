using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RPGGame
{
    public class Armor
    {
        public enum ArmorTypes // создается список с типами брони и их прочностью
        {
            NoneArmor = 0,
            LightArmor = 3,
            MediumArmor = 6,
            HeavyArmor = 10
        }

        public ArmorTypes Type { get; } // свойство типа брони
        public int Durability { get; private set; } // свойство прочтности
        public int EquippedArmor { get; private set; } // одета ли броня

        int speed = 3;

        public Armor(ArmorTypes type, int durability) // конструктор, который хранит тип брони и ее прочность
        {
            Type = type; // тип брони
            Durability = durability; // прочность брони 

        }
        public void TakeDamage(int damage) // создаем метод который бедт выить из брони прочность при получении урона
        {
            ///if (EquippedArmor != null)
            ///{
            ///    // потом реализовать штраф на скорость
            ///}

            Durability -= damage;
            if (Durability < 0) // проверка на то чтобы прочность брони не стала нулевой
            {
                Durability = 0; // делаем нулевую броню
                _ = damage * 2; // удваивание урона при нулевой броне
            }
        }
    }
}
