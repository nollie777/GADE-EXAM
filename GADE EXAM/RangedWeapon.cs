using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class RangedWeapon : Weapon
    {

        public enum Types
        {
            Rifle,
            Longbow
        }

        protected int Range()
        {
            return base.Range(3);
        }

        public RangedWeapon(int X, int Y, Types rangedWeapons) : base(X, Y, 'R')
        {
            if (rangedWeapons == Types.Rifle)
            {
                weaponType = "Rifle";
                Durability = 3;
                Range(3);
                Damage = 5;
                Cost = 7;
            }

            if (rangedWeapons == Types.Longbow)
            {
                weaponType = "Longbow";
                Durability = 4;
                Range(2);
                Damage = 4;
                Cost = 6;
            }
        }



    }

