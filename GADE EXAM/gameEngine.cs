using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
public class GameEngine
{

    private Map map;

    public Map getMap
    {
        get { return map; }
        set { map = value; }
    }

    private Shop shop;

    public Shop getShop
    {
        get { return shop; }
        set { shop = value; }
    }

    public GameEngine(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies, int numGold, int numWeapons)
    {

        map = new Map(minWidth, maxWidth, minHeight, maxHeight, numEnemies, numGold, numWeapons); //instance of Map for game engine

        shop = new Shop(map.getPlayer);

    }

    public enum Movement //new local movement enum
    {
        none,
        up,
        down,
        left,
        right
    }

    public void MovePlayer(Movement direction)  //main player movement method
    {

        switch (direction)
        {

            case Movement.up:
                {

                    if (map.getPlayer.getVision[0] is Gold)  //check tile for gold
                    {

                        for (int i = 0; i < map.getGold.Length; i++)
                        {

                            if (map.getGold[i] == map.getTiles[map.getPlayer.getVision[0].x, map.getPlayer.getVision[0].y])
                            {
                                map.getPlayer.Pickup(map.getGold[i]);

                                Console.WriteLine(map.getPlayer.getGoldPurse);

                            }

                        }

                    }
                    else if (map.getPlayer.getVision[0] is Weapon)
                    {

                        for (int i = 0; i < map.getItem.Length; i++)
                        {
                            if (map.getItem[i] == map.getTiles[map.getPlayer.getVision[0].x, map.getPlayer.getVision[0].y])
                            {
                                map.getPlayer.Pickup(map.getItem[i]);

                                //Console.WriteLine(map.getPlayer.GetWeapon.ToString());
                            }
                        }
                            
                    }

                        //player map movement
                        map.getPlayer.y--;

                    map.getTiles[map.getPlayer.x, map.getPlayer.y] = map.getPlayer;  //move player to new tile

                    map.getTiles[map.getPlayer.x, map.getPlayer.y + 1] = new EmptyTile(map.getPlayer.x, map.getPlayer.y + 1);  //leave empty tile behind

                    map.UpdateVision();
                    map.updateMap();

                    break;

                }
            case Movement.down:
                {


                    if (map.getPlayer.getVision[1] is Gold) //check tile for gold
                    {

                        for (int i = 0; i < map.getGold.Length; i++)
                        {

                            if (map.getGold[i] == map.getTiles[map.getPlayer.getVision[1].x, map.getPlayer.getVision[1].y])
                            {
                                map.getPlayer.Pickup(map.getGold[i]);  //pickup gold

                                Console.WriteLine(map.getPlayer.getGoldPurse);

                            }

                        }

                    }

                    //player map movement
                    map.getPlayer.y++;
                    map.getTiles[map.getPlayer.x, map.getPlayer.y] = map.getPlayer;  //move player to new tile
                    map.getTiles[map.getPlayer.x, map.getPlayer.y - 1] = new EmptyTile(map.getPlayer.x, map.getPlayer.y - 1);  //leave empty tile behind
                    map.UpdateVision();
                    map.updateMap();
                    break;

                }
            case Movement.right:
                {


                    if (map.getPlayer.getVision[3] is Gold) //check tile for gold
                    {

                        for (int i = 0; i < map.getGold.Length; i++)
                        {

                            if (map.getGold[i] == map.getTiles[map.getPlayer.getVision[3].x, map.getPlayer.getVision[3].y])
                            {
                                map.getPlayer.Pickup(map.getGold[i]);

                                Console.WriteLine(map.getPlayer.getGoldPurse);

                            }

                        }

                    }

                    //player map movement
                    map.getPlayer.x++;
                    map.getTiles[map.getPlayer.x, map.getPlayer.y] = map.getPlayer;  //move player to new tile
                    map.getTiles[map.getPlayer.x - 1, map.getPlayer.y] = new EmptyTile(map.getPlayer.x - 1, map.getPlayer.y);  //leave empty tile behind
                    map.UpdateVision();
                    map.updateMap();
                    break;

                }
            case Movement.left:
                {


                    if (map.getPlayer.getVision[2] is Gold) //check tile for gold
                    {

                        for (int i = 0; i < map.getGold.Length; i++)
                        {

                            if (map.getGold[i] == map.getTiles[map.getPlayer.getVision[2].x, map.getPlayer.getVision[2].y])
                            {
                                map.getPlayer.Pickup(map.getGold[i]);

                                Console.WriteLine(map.getPlayer.getGoldPurse);

                            }

                        }

                    }

                    //player map movement
                    map.getPlayer.x--;
                    map.getTiles[map.getPlayer.x, map.getPlayer.y] = map.getPlayer;  //move player to new tile
                    map.getTiles[map.getPlayer.x + 1, map.getPlayer.y] = new EmptyTile(map.getPlayer.x + 1, map.getPlayer.y);  //leave empty tile behind
                    map.UpdateVision();
                    map.updateMap();
                    break;

                }

            default:
                break;
        }


    }

    public void moveGoblin()
    {

        for (int i = 0; i < map.getEnemies.Length; i++)
        {
            map.UpdateVision();
            map.updateMap();
            //if (map.getEnemies[i].)

            Enemy.Movement MoveEnemy = map.getEnemies[i].ReturnMove();

            if ((MoveEnemy) == Enemy.Movement.none)
            {

                map.getTiles[map.getEnemies[i].x, map.getEnemies[i].y] = map.getEnemies[i];
                map.UpdateVision();
                map.updateMap();

            }
            else
            {
                map.getTiles[map.getEnemies[i].x, map.getEnemies[i].y] = new EmptyTile(map.getEnemies[i].x, map.getEnemies[i].y);
                map.getEnemies[i].Move(MoveEnemy);
                map.getTiles[map.getEnemies[i].x, map.getEnemies[i].y] = map.getEnemies[i];
                map.UpdateVision();
                map.updateMap();
            }

            if( map.getEnemies[i] is Leader)
            {
                Leader tempLeader = new Leader(map.getEnemies[i].x, map.getEnemies[i].y, map.getPlayer, map.getEnemies[i].hp);

                map.getEnemies[i] = tempLeader;
            }

            //Console.WriteLine(map.getEnemies[i].ReturnMove() + " || " + map.getEnemies[i].ReturnMove(Character.Movement.up));

        }

    }

    public void mageAttack()
    {

        for (int i = 0; i < map.getEnemies.Length; i++)  //iterate enemies array
        {

            if (map.getEnemies[i] is Mage)
            {

                //Console.WriteLine(map.getEnemies[i]);  for debugging

                for (int j = 0; j < map.getEnemies.Length; j++)
                {

                    if (map.getEnemies[i].CheckRange(map.getPlayer) == true)  //check for player
                    {

                        map.getEnemies[i].Attack(map.getPlayer); //attack player

                    }

                    if (map.getEnemies[i].CheckRange(map.getEnemies[j]) == true)  //check for enemy
                    {

                        map.getEnemies[i].Attack(map.getEnemies[j]); //attack enemy [j] , iterate through all enemies to check

                    }

                }

            }

        }

    }

    public void goblinAttack()
    {

        for (int i = 0; i < map.getEnemies.Length; i++) //iterate enemies array
        {

            if (map.getEnemies[i] is Goblin)
            {

                if (map.getEnemies[i].CheckRange(map.getPlayer) == true)   //goblins can only attack player
                {

                    map.getEnemies[i].Attack(map.getPlayer); //attack player

                }

            }

        }

    }

    public void save()
    {

        //File.Create()

    }

    public override string ToString()
    {
        return map.ToString();
    }

}
