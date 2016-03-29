﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scavanger;
using System.Threading;

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
        public void TestInitialize()
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
        public void IsMovePossibleNoWall()
        {
            player = new Player(100, 100, 1, "player.png", 1, 5, 1, true, 0, AssetLocation.Player, 100, 100);
            world = new World(map, enemies, player, 22, 22);

            Assert.AreEqual(false, world.IsMovePossible(player, Direction.Down));
        }

        [TestMethod]
        public void IsMovePossibleNoEnemy()
        {
            player = new Player(100, 100, 1, "player.png", 1, 1, 1, true, 0, AssetLocation.Player, 100, 100);
            enemies.Add(new Enemy(100, 100, 1, "troll.png", 1, 2, 1, true, 10, AssetLocation.Enemy, 2, true));
            world = new World(map, enemies, player, 22, 22);

            Assert.AreEqual(false, world.IsMovePossible(player, Direction.Down));
        }

        [TestMethod]
        public void MovePlayerDownAllowed()
        {
            int playerY = 1;
            player = new Player(100, 100, 1, "player.png", 1, playerY, 1, true, 0, AssetLocation.Player, 100, 100);
            world = new World(map, enemies, player, 22, 22);

            world.keyPressed = Direction.Down;
            MovePlayer();
            Assert.AreEqual(playerY+1, player.Y);
            Assert.AreEqual(95, player.Food);
        }

        [TestMethod]
        public void MovePlayerDownNotAllowed()
        {
            int playerY = 5;
            player = new Player(100, 100, 1, "player.png", 1, playerY, 1, true, 0, AssetLocation.Player, 100, 100);
            world = new World(map, enemies, player, 22, 22);

            world.keyPressed = Direction.Down;
            MovePlayer();
            Assert.AreEqual(playerY, player.Y);
            Assert.AreEqual(100, player.Food);
        }

        private void MovePlayer()
        {
            Thread thread = new Thread(world.MovePlayer);
            thread.Start();
            thread.Join(1000);
        }
    }
}
