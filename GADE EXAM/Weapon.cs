using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Weapon : Item
    {

        //constructor 

        public Weapon(int X, int Y, char symbol) : base(X, Y)
        {

        }

        //protected 

        protected int Damage;

        protected virtual int Range(int _range)
        {
            return _range;
        }

        protected int Durability;

        protected int Cost;

        protected string weaponType;

        //public

        public int damage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public int durability
        {
            get { return Durability; }
            set { Durability = value; }
        }

        public int cost
        {
            get { return Cost; }
            set { Cost = value; }
        }

        public string _type
        {
            get { return weaponType; }
            set { weaponType = value; }
        }


    public enum Types
    {
        Dagger,
        Longsword,
        Rifle,
        Longbow
    }

    //methods

    public override string ToString()
        {
            return weaponType;
        }
    }

