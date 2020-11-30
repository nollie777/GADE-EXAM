using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mage : Enemy
{

    public int tempRange = 1;

    public Mage(int X, int Y, int HP = 5, int damage = 5) : base(X, Y, HP, damage) //constructor
    {

    }

    public override Movement ReturnMove(Movement move = Movement.none)
    {
        return Movement.none;
    }


    public override bool CheckRange(Character target)
    {
        if ((this.x++ == target.x && this.y == target.y) || (this.x-- == target.x && this.y == target.y)) //check x, same y
        {

            return true;
        }
        if ((this.x == target.x && this.y++ == target.y) || (this.x == target.x && this.y-- == target.y)) //check y, same x
        {

            return true;
        }
        if ((this.x++ == target.x && this.y++ == target.y) || (this.x-- == target.x && this.y-- == target.y)) //check x & y
        {

            return true;
        }
        if ((this.x++ == target.x && this.y-- == target.y) || (this.x-- == target.x && this.y++ == target.y)) //check x & y
        {

            return true;
        }

        else
            return false;

    }

    public override Movement checkMove(Movement move)
    {
        return Movement.none;

    }

}
