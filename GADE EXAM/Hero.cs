using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Hero : Character
{
    public Hero(int Xpos, int Ypos, int hp, int _maxhp, int damage = 10, int _goldPurse = 0) : base(Xpos, Ypos)
    {

        X = Xpos;

        Y = Ypos;

        HP = hp;

        maxHP = _maxhp;

        goldPurse = _goldPurse;

        //  Console.WriteLine(X + " " + Y);

    }

    public override Movement ReturnMove(Movement move = Movement.none)  //receives a string based on movement and then updates characters X and Y values
    {

        switch (move)
        {

            case (Movement.up):
                if (getVision[0] is EmptyTile || getVision[0] is Item)
                {
                    return Movement.up;
                }
                else
                {
                    return Movement.none;
                }
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

    public override Movement checkMove(Movement move)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return (String.Format("Player Stats: \nHP: {0}/{1} \nDamage: {2} \n[{3}, {4}] \nGold:{5}", HP, maxHP, Damage, X, Y, goldPurse));  //Concatinate information
    }
}
