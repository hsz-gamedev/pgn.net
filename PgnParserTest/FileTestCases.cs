﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ilf.pgn.Test
{
    [TestClass]
    [DeploymentItem(TestFolder, TestFolder)]
    public class FileTestCases
    {
        private const string TestFolder = @"Test Files\";

        [TestMethod]
        public void EmptyFile()
        {
            var parser = new Parser();
            var db = parser.ReadFromFile(TestFolder + "empty-file.pgn");
            Assert.AreEqual(0, db.Games.Count);
        }

        [TestMethod]
        public void SimpleGame()
        {
            var parser = new Parser();
            var db = parser.ReadFromFile(TestFolder + "simple-game.pgn");
            Assert.AreEqual(1, db.Games.Count);
        }

        //[TestMethod]
        //public void TimeAnnotatedGammes()
        //{
        //    var parser = new Parser();
        //    var db = parser.ReadFromFile(TestFolder + "time-annotated-games.pgn");
        //    Assert.AreEqual(4, db.Games.Count);
        //}
    }
}
