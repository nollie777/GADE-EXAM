using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Shop
    {

        //private 

        private Weapon[] weaponArray = new Weapon[3];

        private Random rando = new Random();

        private Character buyer;

        //constructor

        public Shop(Character _buyer)
        {

            buyer = new Hero(_buyer.x, _buyer.y, _buyer.hp, _buyer.getGoldPurse);

            for (int i =0; i < 3; i++)
            {

                weaponArray[i] = RandomWeapon();

            }

        }

        //methods 

        private Weapon RandomWeapon()
        {

            //Random rando = new Random(Guid.NewGuid().GetHashCode());

            int randWeapon = rando.Next(0, 4);

            switch (randWeapon)
            {
                case (0):
                    
                    MeleeWeapon Dagger = new MeleeWeapon(1,1,MeleeWeapon.Types.Dagger);
                    return Dagger;
                    
                case (1):
                    
                    MeleeWeapon Longsword = new MeleeWeapon(1, 1, MeleeWeapon.Types.Longsword);
                    return Longsword;

                case (2):

                    RangedWeapon Longbow = new RangedWeapon(1, 1, RangedWeapon.Types.Longbow);
                    return Longbow;

                case (3):

                    RangedWeapon Rifle = new RangedWeapon(1, 1, RangedWeapon.Types.Rifle);
                    return Rifle;


                default:
                    break;
            }

            return null;

        }

        public bool CanBuy(int num)
        {

            if (buyer.getGoldPurse >= weaponArray[num].cost)
            {

                return true;

            }
            else
                return false;

        }

        public void Buy(int num)
        {

            buyer.getGoldPurse =- weaponArray[num].cost;

            buyer.Pickup(weaponArray[num]);

            weaponArray[num] = RandomWeapon();

        }

        public string DisplayWeapon(int num)
        {
            return ("Buy " + weaponArray[num]._type + " " + weaponArray[num].cost + " Gold");
        }

    }
