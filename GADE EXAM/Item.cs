using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Item : Tile
{

    public Item(int X, int Y) : base(X, Y)
    {

    }

    public abstract string ToString();

}
