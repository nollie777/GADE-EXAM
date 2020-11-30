using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Enemy : Character
{
    public Enemy(int X, int Y, int HP, int Damage) : base(X, Y) //constructor
    {

        hp = HP;

        damage = Damage;

        _maxHP = HP;

    }

    //protected Random rando = new Random();

    public override string ToString()
    {
        return (String.Format("{0} at [{1}, {2}] (Damage: {3}) (HP: {4})", this.GetType().Name, X, Y, Damage, HP));  //tostring goblin
    }
}
class Goblin : Enemy
{

    public override Movement ReturnMove(Movement move = Movement.none)
    {

        Random rando = new Random(Guid.NewGuid().GetHashCode());

        int randmove = 0;

        randmove = rando.Next(0, 5);

        switch (randmove)   //based on the random number generated, the goblin moves in one of 5 directions
        {
            case (0):

                return Movement.none;

            case (1):

                if (this.visionArray[0] is EmptyTile || this.visionArray[0] is Item)
                {

                    //Console.WriteLine("returnmove goblin: " + randmove + this.visionArray[0]);

                    return Movement.up;

                }
                else if (this.visionArray[0] is Obstacle || this.visionArray[0] is Character)
                {
                    return Movement.none;
                }
                else
                {
                    return Movement.none;
                }

            case (2):


                if (this.visionArray[1] is EmptyTile || this.visionArray[1] is Item)
                {
                    return Movement.down;
                }
                else if (this.visionArray[1] is Obstacle || this.visionArray[1] is Character)
                {
                    return Movement.none;
                }
                else
                {
                    return Movement.none;
                }


            case (3):

                if (this.visionArray[2] is EmptyTile || this.visionArray[2] is Item)
                {
                    return Movement.left;
                }
                else if (this.visionArray[2] is Obstacle || this.visionArray[2] is Character)
                {
                    return Movement.none;
                }
                else
                {
                    return Movement.none;
                }

            case (4):


                if (this.visionArray[3] is EmptyTile || this.visionArray[3] is Item)
                {
                    return Movement.right;
                }
                else if (this.visionArray[3] is Obstacle || this.visionArray[3] is Character)
                {
                    return Movement.none;
                }
                else
                {
                    return Movement.none;
                }

            default:
                break;


        }

        return Movement.none;
    }

    public override Movement checkMove(Movement move)
    {
        switch (move)
        {

            case (Movement.up):
                if (getVision[0] is EmptyTile || getVision[0] is Item)
                {
                    return Movement.up;
                }
                else if (getVision[0] is Obstacle)
                {
                    return Movement.none;
                }
                else
                    return Movement.none;
            case (Movement.down):
                if (getVision[1] is EmptyTile || getVision[1] is Item)
                {
                    return Movement.down;
                }
                else
                {
                    return Movement.none;
                }
            case (Movement.left):
                if (getVision[2] is EmptyTile || getVision[2] is Item)
                {
                    return Movement.left;
                }
                else
                {
                    return Movement.none;
                }
            case (Movement.right):
                if (getVision[3] is EmptyTile || getVision[3] is Item)
                {
                    return Movement.right;
                }
                else
                {
                    return Movement.none;
                }


        }
        return Movement.none;
    }

    public Goblin(int X, int Y, int HP = 10, int damage = 1) : base(X, Y, HP, damage) //constructor
    {

    }

}
