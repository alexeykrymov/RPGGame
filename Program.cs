using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    interface ICharacteristics
    {
        int Strength(/*int health = 3*/);
        int Agility();
        (int,int) Intelligence();
    }

    class People : ICharacteristics
    {
        public int Strength(/*int health*/)
        {
            int health = 3;
            return health;
            //this.health = health;
            //return health;
        }
        public int Agility()
        {
            int speed = 3;
            int stels = 3;
            return speed + stels;
        }

        //public int Intelligence()
        //{
        //    int planning = 3;
        //    int trade = 3;
        //    return planning;
        //}

        public (int, int) Intelligence()
        {
            int planning = 3;
            int trade = 3;
            return (planning, trade);
        }
    }
    class Ork : ICharacteristics
    {
        public int Strength(/*int health*/)
        {
            int health = 5;
            return health;
            //this.health = health;
            //return health;
        }
        public int Agility()
        {
            int speed = 4;
            int stels = 0;
            return speed + stels;
        }

        public (int,int) Intelligence()
        {
            int planning = 1;
            int trade = 2;
            return (planning,trade);
        }
    }
    class Undead : ICharacteristics
    {
        public int Strength(/*int health*/)
        {
            int health = 1;
            int revival = 1;
            while (revival == 1)
            {
                if (health == 0 && revival == 1)
                {
                    health = 3;
                    revival--;
                    return health;
                }
                if (revival == 0)
                {
                    break; // Выход из цикла
                }                
            }

            return health;
        }
        public int Agility()
        {
            int speed = 5;
            int stels = 5;
            return speed + stels;
        }

        public (int,int) Intelligence()
        {
            int planning = 0;
            int trade = 0;
            return (planning,trade);
        }
    }
}
