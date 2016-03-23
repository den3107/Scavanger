using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scavanger;

namespace ScavangerTests
{
    [TestClass]
    public class WorldUnitTest
    {
        Tile[,] tiles;
        Map map;
        List<Enemy> enemies;
        Player player;
        World world;

        [TestInitialize]
        private void InitTest()
        {
            tiles = new Tile[, ] { { new Tile("Wall.png", false), new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false),  new Tile("Wall.png", false)  },
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
        public void IsMovePossibleYes()
        {
            player = new Player(100, 100, 1, "player.png", 1, 1, 1, true, 0, AssetLocation.Player, 100, 100);
            world = new World(map, enemies, player, 22, 22);

            Assert.AreEqual(true, world.IsMovePossible(player, Direction.Down));
        }

        [TestMethod]
        public void IsMovePossibleNo()
        {
            player = new Player(100, 100, 1, "player.png", 1, 5, 1, true, 0, AssetLocation.Player, 100, 100);
            world = new World(map, enemies, player, 22, 22);

            Assert.AreEqual(true, world.IsMovePossible(player, Direction.Down));
        }

        [TestMethod]
        public void MovePlayerDownAllowed()
        {
            int playerY = 1;
            player = new Player(100, 100, 1, "player.png", 1, playerY, 1, true, 0, AssetLocation.Player, 100, 100);
            world = new World(map, enemies, player, 22, 22);

            world.keyPressed = Direction.Down;
            world.MovePlayer();
            Assert.AreEqual(playerY+1, player.Y);
        }

        [TestMethod]
        public void MovePlayerDownNotAllowed()
        {
            int playerY = 5;
            player = new Player(100, 100, 1, "player.png", 1, playerY, 1, true, 0, AssetLocation.Player, 100, 100);
            world = new World(map, enemies, player, 22, 22);

            world.keyPressed = Direction.Down;
            world.MovePlayer();
            Assert.AreEqual(playerY, player.Y);
        }
    }
}
