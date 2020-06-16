using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NumberPuzzleWeb.Core.ApplicationServices;
using NumberPuzzleWeb.Core.DomainModel;
using NumberPuzzleWeb.Core.DomainServes;
using NUnit.Framework;


namespace NumberPuzzleWebUnitTest
{
    class GameServiceTest
    {


        [Test]

         public async Task TestStartGame()
        {
            var mock = new Mock<IGameModelRepostery>();
            mock.Setup(repo => repo.Create(It.IsAny<GameModel>()))
                .Returns(Task.FromResult(true));
            var gameService = new GameService (mock.Object);
          var  gameModel = await gameService.StartGame();
          Assert.IsNotNull(gameModel);
          Assert.AreEqual(0, gameModel.PlayCount);
          mock.Verify(repo=> repo.Create(gameModel), Times.Once);
          mock.VerifyNoOtherCalls();
        }

         [Test]
         public async Task TestPlay()
         {
             var gameId = new Guid("ee4c7af3-26ae-452b-9d61-b4a0bf3ddd1b");
             var gameModel = new GameModel(gameId, 7, new[] { 1, 3, 2, 4, 5, 6, 7, 8, 0 });
             var mock = new Mock<IGameModelRepostery>();
             var setUp = mock.Setup(repo => repo.Read(gameId))
                 .Returns(Task.FromResult(gameModel));
             var gameService = new GameService(mock.Object);
             await gameService.Play(7, gameId);
             Assert.AreEqual('8', gameModel[8]);
             mock.Verify(repo => repo.Read(gameId), Times.Once);
             mock.Verify(repo => repo.Update(gameModel), Times.Once);
            mock.VerifyNoOtherCalls();
         }

        [Test]
         public async Task TestRead()
         {
             var gameId = new Guid("ee4c7af3-26ae-452b-9d61-b4a0bf3ddd1b");
             var gameModel = new GameModel(gameId, 7, new[] {1, 3, 2, 4, 5, 6, 7, 8, 0});
             var mock = new Mock<IGameModelRepostery>();
            var setUp= mock.Setup(repo => repo.Read(gameId))
                 .Returns(Task.FromResult(gameModel));
             var gameService = new GameService(mock.Object);
             var gameModel2 = await gameService.Read(gameId);
             Assert.AreEqual(gameModel,gameModel2);
             mock.Verify(repo => repo.Read(gameId), Times.Once);
             mock.VerifyNoOtherCalls();
         }
        
    }
}
