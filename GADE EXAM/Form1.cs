using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_EXAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblshop.Text = "";

            for (int i =0; i < 3; i++)
            {
                lblshop.Text += ("Items: \n" + game.getShop.DisplayWeapon(i));
            }

        }

        GameEngine game = new GameEngine(10, 10, 10, 10, 5, 3, 2);  //create new instance of map in form1


        private void btn_left_Click(object sender, EventArgs e)  //left movement
        {

            if (game.getMap.getPlayer.ReturnMove(Character.Movement.left) == Character.Movement.left)
            {
                game.MovePlayer(GameEngine.Movement.left);
            }

            enemyActions();

            lblPlayer.Text = game.getMap.getPlayer.ToString();

            lblmap.Text = game.ToString();

        }

        private void btn_up_Click(object sender, EventArgs e) //up movement
        {

            if (game.getMap.getPlayer.ReturnMove(Character.Movement.up) == Character.Movement.up)
            {

                game.MovePlayer(GameEngine.Movement.up);

            }

            enemyActions();

            lblPlayer.Text = game.getMap.getPlayer.ToString();

            lblmap.Text = game.ToString();

        }

        private void btn_down_Click(object sender, EventArgs e) //down movement
        {

            if (game.getMap.getPlayer.ReturnMove(Character.Movement.down) == Character.Movement.down)
            {

                game.MovePlayer(GameEngine.Movement.down);

            }

            enemyActions();

            lblPlayer.Text = game.getMap.getPlayer.ToString();

            lblmap.Text = game.ToString();

        }

        private void btn_right_Click(object sender, EventArgs e) //right movement
        {

            if (game.getMap.getPlayer.ReturnMove(Character.Movement.right) == Character.Movement.right)
            {

                game.MovePlayer(GameEngine.Movement.right);

            }

            enemyActions();

            lblPlayer.Text = game.getMap.getPlayer.ToString();

            lblmap.Text = game.ToString();

        }

        private void btn_attack_Click(object sender, EventArgs e) //button under listbox
        {

            int i = actionlist.SelectedIndex;  //get listbox index 

            if (game.getMap.getPlayer.CheckRange(game.getMap.getEnemies[i]) == true)
            {

                if (actionlist.SelectedItem.ToString() == (game.getMap.getEnemies[i].ToString()))
                {

                    //actionlist.Items.Add(game.getMap.getEnemies[i]); 

                    game.getMap.getPlayer.Attack(game.getMap.getEnemies[i]);

                    actionlist.Items.Add(game.getMap.getEnemies[i].hp);

                    bool checkDead = game.getMap.getEnemies[i].IsDead(); //use new variable for is dead method

                    if (checkDead == true)
                    {

                        game.getMap.getTiles[game.getMap.getEnemies[i].x, game.getMap.getEnemies[i].y] = new EmptyTile(game.getMap.getEnemies[i].x, game.getMap.getEnemies[i].y);

                        game.getMap.UpdateVision();

                        lblmap.Text = game.ToString();

                    }
                }


            }

            enemyActions();
        }

        public void enemyActions()
        {

            game.moveGoblin();

            game.mageAttack();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            lblmap.Text = game.ToString();

            for (int i = 0; i < game.getMap.getPlayer.getVision.Length + 1; i++)
            {
                actionlist.Items.Add(game.getMap.getEnemies[i]);  //load enemies into listbox
            }

        }

        private void btn_left_Click_1(object sender, EventArgs e)
        {


            if (game.getMap.getPlayer.ReturnMove(Character.Movement.left) == Character.Movement.left)
            {
                game.MovePlayer(GameEngine.Movement.left);
            }

            enemyActions();

            lblPlayer.Text = game.getMap.getPlayer.ToString();

            lblmap.Text = game.ToString();


        }

        private void btn_down_Click_1(object sender, EventArgs e)
        {

            if (game.getMap.getPlayer.ReturnMove(Character.Movement.down) == Character.Movement.down)
            {

                game.MovePlayer(GameEngine.Movement.down);

            }

            enemyActions();

            lblPlayer.Text = game.getMap.getPlayer.ToString();

            lblmap.Text = game.ToString();

        }

        private void btn_up_Click_1(object sender, EventArgs e)
        {

            if (game.getMap.getPlayer.ReturnMove(Character.Movement.up) == Character.Movement.up)
            {

                game.MovePlayer(GameEngine.Movement.up);

            }

            enemyActions();

            lblPlayer.Text = game.getMap.getPlayer.ToString();

            lblmap.Text = game.ToString();

        }

        private void btn_right_Click_1(object sender, EventArgs e)
        {

            if (game.getMap.getPlayer.ReturnMove(Character.Movement.right) == Character.Movement.right)
            {

                game.MovePlayer(GameEngine.Movement.right);

            }

            enemyActions();

            lblPlayer.Text = game.getMap.getPlayer.ToString();

            lblmap.Text = game.ToString();

        }
    }
}

