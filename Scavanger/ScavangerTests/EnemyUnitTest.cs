using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scavanger;

namespace ScavangerTests
{
    [TestClass]
    public class EnemyUnitTest
    {
        Tile[,] tiles;
        Map map;
        List<Enemy> enemies;
        Player player;
        World world;

        [TestInitialize]
        public void TestInitialize()
        {
            tiles = new Tile[,] { { new Tile("Wall.png", false), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false)  },
                                 { new Tile("Wall.png", false), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("Wall.png", false)  },
                                 { new Tile("Wall.png", false), new Tile("Wall.png", false),  new Tile("ground.png", true), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("ground.png", true), new Tile("Wall.png", false)  },
                                 { new Tile("Wall.png", false), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("ground.png", true), new Tile("Wall.png", false)  },
                                 { new Tile("Wall.png", false), new Tile("ground.png", true), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false)  },
                                 { new Tile("Wall.png", false), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("ground.png", true), new Tile("Wall.png", false)  },
                                 { new Tile("Wall.png", false), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("ground.png", true), new Tile("Wall.png", false)  }};
            map = new Map(tiles, null, null, 6, 5, 1, 1);
            enemies = new List<Enemy>();
        }

        [TestMethod]
        public void CanSeePlayerYes()
        {
            player = new Player(100, 100, 1, "player.png", 1, 1, 1, true, 0, AssetLocation.Player, 100, 100);
            enemies.Add(new Enemy(100, 100, 1, "troll.png", 1, 3, 1, true, 10, AssetLocation.Enemy, 2, true));
            world = new World(map, enemies, player, 22, 22);

            Assert.AreNotEqual(Direction.None, enemies[0].CanSeePlayer(world));
        }

        [TestMethod]
        public void CanSeePlayerNoLine()
        {
            player = new Player(100, 100, 1, "player.png", 1, 1, 1, true, 0, AssetLocation.Player, 100, 100);
            enemies.Add(new Enemy(100, 100, 1, "troll.png", 2, 2, 1, true, 10, AssetLocation.Enemy, 2, true));
            world = new World(map, enemies, player, 22, 22);

            Assert.AreEqual(Direction.None, enemies[0].CanSeePlayer(world));
        }

        [TestMethod]
        public void CanSeePlayerNoWall()
        {
            player = new Player(100, 100, 1, "player.png", 2, 2, 1, true, 0, AssetLocation.Player, 100, 100);
            enemies.Add(new Enemy(100, 100, 1, "troll.png", 2, 5, 1, true, 10, AssetLocation.Enemy, 2, true));
            world = new World(map, enemies, player, 22, 22);

            Assert.AreEqual(Direction.None, enemies[0].CanSeePlayer(world));
        }
    }
}
