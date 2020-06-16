using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NumberPuzzleWeb.Core.DomainModel;
using NumberPuzzleWeb.Core.DomainServes;

namespace NumberPuzzleWeb.Infrastructure.DataAccess.Repository
{
    class GameModellRepostery : IGameModelRepostery
    {
        public Task<bool> Create(GameModel gameModel)
        {
            throw new NotImplementedException();
        }

        public Task<GameModel> Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(GameModel gameModel)
        {
            throw new NotImplementedException();
        }
    }
}
