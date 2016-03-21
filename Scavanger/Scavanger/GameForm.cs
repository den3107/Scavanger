using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scavanger
{
    public partial class GameForm : Form
    {
        readonly private int moveDelay = 500;

        readonly private Menu parent;

        private World world;

        private String turnText;
        private Color turnColor;

        public GameForm(Menu parent)
        {
            InitializeComponent();

            this.parent = parent;

            turnText = "";
            turnColor = Color.White;

        // Link foreground picturebox to background picturebox for transparency to work
        entitiesPictureBox.Parent = backgroundPictureBox;

            // Create testing map
            Tile[,] tiles = { { new Tile("Wall.png", false), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false)  },
                              { new Tile("Wall.png", false), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("Wall.png", false)  },
                              { new Tile("Wall.png", false), new Tile("Wall.png", false),  new Tile("ground.png", true), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("ground.png", true), new Tile("Wall.png", false)  },
                              { new Tile("Wall.png", false), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("ground.png", true), new Tile("Wall.png", false)  },
                              { new Tile("Wall.png", false), new Tile("ground.png", true), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false)  },
                              { new Tile("Wall.png", false), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("Wall.png", false)  },
                              { new Tile("Wall.png", false), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("ground.png", true), new Tile("Wall.png", false)  } };
            Map map = new Map(tiles, null, null, 6, 5, 1, 1);
            List<Enemy> enemies = new List<Enemy>();
            enemies.Add(new Enemy(10, 1, "troll.png", 3, 5, 1, true, 10, AssetLocation.Enemy, 2, true));
            Player player = new Player(100, 1, "player.png", 1, 1, 1, true, 0, AssetLocation.Player, 100);
            world = new World(map, enemies, player, backgroundPictureBox.Height / 32, backgroundPictureBox.Width / 32);

            UpdateStats();

            Task.Factory.StartNew(Run);
        }

        private void Run()
        {
            while (true)
            {
                if(CheckPlayerDeath())
                {
                    break;
                }
                
                ChangeTurnLabel("It's your turn", Color.Green);
                world.MovePlayer();

                if (world.PlayerAtEnd())
                {
                    ChangeTurnLabel("You reached the end", Color.Green);
                    break;
                }

                ChangeTurnLabel("It's the enemy's turn", Color.Red);
                world.MoveEnemies(moveDelay);

                if (CheckPlayerDeath())
                {
                    break;
                }
            }
        }

        private void backgroundPictureBox_Paint(object sender, PaintEventArgs e)
        {
            world.DrawMap(e.Graphics);
        }

        private void entitiesPictureBox_Paint(object sender, PaintEventArgs e)
        {
            world.DrawEntities(e.Graphics);
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            turnLabel.Text = turnText;
            turnLabel.ForeColor = turnColor;
            UpdateStats();
            CheckPlayerDeath();
            entitiesPictureBox.Invalidate();
        }

        private bool CheckPlayerDeath()
        {
            if (world.PlayerDead())
            {
                ChangeTurnLabel("You died", Color.Red);
                return true;
            }
            return false;
        }

        private void UpdateStats()
        {
            healthLabel.Text = world.Player.Health + "/" + world.Player.MaxHealth;
            foodLabel.Text = world.Player.Food + "/" + world.Player.MaxFood;
            strengthLabel.Text = world.Player.Strength.ToString();
            speedLabel.Text = world.Player.Speed.ToString();
            rangeLabel.Text = world.Player.Range.ToString();
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    lock(world)
                    {
                    world.keyPressed = Direction.Down;
                    }
                    break;
                case Keys.Left:
                    lock (world)
                    {
                        world.keyPressed = Direction.Left;
                    }
                    break;
                case Keys.Right:
                    lock (world)
                    {
                        world.keyPressed = Direction.Right;
                    }
                    break;
                case Keys.Up:
                    lock (world)
                    {
                        world.keyPressed = Direction.Up;
                    }
                    break;
            }
        }

        private void ChangeTurnLabel(String s, Color c)
        {
            MethodInvoker mi = delegate
            {
                lock (turnText)
                {
                    turnText = s;
                    turnColor = c;
                }
            };
            if (InvokeRequired)
            {
                BeginInvoke(mi);
            }
            else
            {
                mi.Invoke();
            }
        }
    }
}
