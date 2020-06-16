using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using NumberPuzzleWeb.Core.DomainModel;
using NumberPuzzleWeb.Core.DomainServes;

namespace NumberPuzzleWeb.Core.ApplicationServices
{
    public class GameService
    {
        private readonly IGameModelRepostery _repostery;

        public GameService(IGameModelRepostery Repostery)
        {
            _repostery = Repostery;
        }

        public async Task<GameModel> StartGame()
        {
            var gameModel = new  GameModel();
            await _repostery.Create(gameModel);
            return gameModel;
            
        }

        public async Task<GameModel> Read(Guid gameId)
        {
            return await _repostery.Read(gameId);
        }

        public async Task<GameModel> Play(int index, Guid gameId)
        {
            var gameModel = await _repostery.Read(gameId);
            var hasPlayed = gameModel.Play(index);
            await _repostery.Update(gameModel);
            return gameModel;
        }

    }
}
