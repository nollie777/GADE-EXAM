using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Leader : Enemy
    {

        private Tile targetTile;

        public Tile _targetTile
        {
            get { return targetTile; }
            set { targetTile = value; }
        }

        //protected Character targetHero = new Character();

        //protected Character targetHero;

        public Leader(int X, int Y, Character targetHero, int HP = 20, int Damage = 2) : base(X, Y, HP, Damage) 
        {

            targetTile = new Hero(targetHero.x, targetHero.y, targetHero.hp, targetHero._maxHP);

        }



    public override Movement ReturnMove(Movement move = Movement.none)
    {

        

        if (targetTile.x == this.x)  //on same x axis
        {

            //Console.WriteLine("same X axis || Leader X = " + this.x + " Target X = " + targetTile.x);

            if (targetTile.y < this.y && (this.visionArray[0] is EmptyTile || this.visionArray[0] is Item))  //for moving up
            {
                //Console.WriteLine("same X axis move UP");

                return Movement.up;
            }
            else if (targetTile.y > this.y && (this.visionArray[1] is EmptyTile || this.visionArray[1] is Item)) //for moving down
            {
                //Console.WriteLine("same X axis move DOWN");

                return Movement.down;
            }
            else
            {
                //Console.WriteLine("same X axis random move || DOWN = " + this.visionArray[1]);

                return randomMove();  //random move if facing something
            }
        }
        else if (targetTile.y == this.y) //on same y axis
        {
            //Console.WriteLine("same y axis || Leader Y = "+ this.y + " Target Y = "+ targetTile.y);

            if (targetTile.x < this.x && (this.visionArray[3] is EmptyTile || this.visionArray[3] is Item))  //for moving right
            {
                return Movement.right;
            }
            else if (targetTile.x > this.x && (this.visionArray[2] is EmptyTile || this.visionArray[2] is Item)) //for moving left
            {
                return Movement.left;
            }
            else
            {
                return randomMove();  //random move if facing something
            }
        }

        else if (targetTile.x > this.x && (this.visionArray[3] is EmptyTile || this.visionArray[3] is Item))
        {

            return Movement.right;
        }
        else if (targetTile.x < this.x && (this.visionArray[2] is EmptyTile || this.visionArray[2] is Item))
        {

            return Movement.left;
        }
        else if (targetTile.y < this.y && (this.visionArray[0] is EmptyTile || this.visionArray[0] is Item))
        {

            return Movement.up;

        }
        else if (targetTile.y > this.y && (this.visionArray[1] is EmptyTile || this.visionArray[1] is Item))
        {

            return Movement.down;

        }
        else
        {
            return randomMove();
        }
    }
    

    public Movement randomMove() //get a random movement if something is in front of leader
    {
        Random rando = new Random(Guid.NewGuid().GetHashCode());

        int randmove = 0;

        randmove = rando.Next(0, 5);

        switch (randmove)   //based on the random number generated, the goblin moves in one of 5 directions
        {
            case (0):

                return randomMove();

            case (1):

                if (this.visionArray[0] is EmptyTile || this.visionArray[0] is Item)
                {

                    //Console.WriteLine("returnmove goblin: " + randmove + this.visionArray[0]);

                    return Movement.up;

                }
                else if (this.visionArray[0] is Obstacle || this.visionArray[0] is Character)
                {
                    return randomMove();
                }
                else
                {
                    return randomMove();
                }

            case (2):


                if (this.visionArray[1] is EmptyTile || this.visionArray[1] is Item)
                {
                    return Movement.down;
                }
                else if (this.visionArray[1] is Obstacle || this.visionArray[1] is Character)
                {
                    return randomMove();
                }
                else
                {
                    return randomMove();
                }


            case (3):

                if (this.visionArray[2] is EmptyTile || this.visionArray[2] is Item)
                {
                    return Movement.left;
                }
                else if (this.visionArray[2] is Obstacle || this.visionArray[2] is Character)
                {
                    return randomMove();
                }
                else
                {
                    return randomMove();
                }

            case (4):


                if (this.visionArray[3] is EmptyTile || this.visionArray[3] is Item)
                {
                    return Movement.right;
                }
                else if (this.visionArray[3] is Obstacle || this.visionArray[3] is Character)
                {
                    return randomMove();
                }
                else
                {
                    return randomMove();
                }

            default:
                break;


        }

        return Movement.none;
    }


    public override Movement checkMove(Movement move)
        {
            return Movement.none;
        }
    }