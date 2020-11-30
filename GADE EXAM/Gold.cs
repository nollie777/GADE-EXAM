using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Gold : Item
{
    //variables
    private int goldAmount;

    private Random randGold = new Random();

    //getters n setters

    public int getGoldAmount
    {
        get { return goldAmount; }
        set { goldAmount = value; }
    }

    //construsctor

    public Gold(int X, int Y) : base(X, Y)
    {

        goldAmount = randGold.Next(1, 5);

    }

    public override string ToString()
    {
        return "Gold";
    }

}
