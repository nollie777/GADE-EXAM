using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MeleeWeapon : Weapon
    {

        //public vars

        public enum Types
        {
            Dagger,
            Longsword
        }

        protected int Range()
        {
            return 1;
        }

        //constructor

        public MeleeWeapon(int X, int Y, Types meleeType) : base(X, Y, 'M')
        {

            if (meleeType == Types.Dagger)
            {
                weaponType = "Dagger";
                Durability = 10;
                Damage = 3;
                Cost = 3;
            }
            if(meleeType == Types.Longsword)
            {
                weaponType = "Longsword";
                Durability = 6;
                Damage = 4;
                Cost = 5;
            }

        }

    }

