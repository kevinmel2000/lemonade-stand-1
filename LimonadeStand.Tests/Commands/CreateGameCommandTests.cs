﻿using LimonadeStand.Common;
using LimonadeStand.Common.Commands;
using LimonadeStand.Tests.Fakes;
using NUnit.Framework;

namespace LimonadeStand.Tests.Commands
{
    [TestFixture]
    public class CreateGameCommandTests
    {
        private FakeRepository<Game> repository;

        [SetUp]
        public void Setup()
        {
            repository = new FakeRepository<Game>();
        }

        [Test]
        public void Execute_CreatesGameWithPlayers()
        {
            var command = new CreateGameCommand(repository);
            var result = command.Execute(new CreateGame(new[] { "Player 1", "Player 2" }));
            var game = repository.Items[0];
            Assert.AreEqual(result.Id, game.Id);
        }
    }
}
