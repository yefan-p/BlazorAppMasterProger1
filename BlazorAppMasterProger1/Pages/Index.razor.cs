using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

using BlazorAppMasterProger1.Repository;
using BlazorAppMasterProger1.Model;
using BlazorAppMasterProger1.Shared;

namespace BlazorAppMasterProger1.Pages
{
    public partial class Index
    {
        [Inject] IRepository _repository { get; set; }

        List<Game> games;

        Random rnd;

        Game oneGameToShow;

        GameListTable _gameListTable;

        protected async override Task OnInitializedAsync()
        {
            //await Task.Delay(2000);
            games = _repository.GetAllGames();

            rnd = new Random(DateTime.Now.Millisecond);
            oneGameToShow = games[rnd.Next(0, games.Count)];
        }

        void AddNewGame()
        {
            games.Add(new Game() { Name = "Game for test", Genre = "Test", ReleaseDate = DateTime.Now });
        }

        void ShowNewGame()
        {
            oneGameToShow = SwitchGame();
        }

        Game SwitchGame()
        {
            Game tempGame;

            if (games.Count >= 2)
            {
                int inerator = rnd.Next(0, games.Count);
                tempGame = games[inerator];
            }
            else if (games.Count == 1)
                tempGame = games[0];
            else
                return new Game() { Name = "No items in array!", ReleaseDate = DateTime.Now };

            return tempGame;
        }
    }
}
