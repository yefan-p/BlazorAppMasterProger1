using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BlazorAppMasterProger1.Model;
using BlazorAppMasterProger1.Utils;

namespace BlazorAppMasterProger1.Repository
{
    public class MockGamesRepository : IRepository
    {
        List<Game> _games;

        public MockGamesRepository()
        {
            _games = new List<Game>()
            {
                new Game()
                {
                    Name = "Farming Simulator 2019",
                    Genre = "Simulator",
                    ReleaseDate = new DateTime(2018, 11, 19)
                },
                new Game()
                {
                    Name = "The Witcher 3",
                    Genre = "RPG",
                    ReleaseDate = new DateTime(2015, 05, 18)
                },
                new Game()
                {
                    Name = "Destroy All Humans!",
                    Genre = "Action",
                    ReleaseDate = new DateTime(2020, 07, 28)
                },
                new Game()
                {
                    Name = "Farming Simulator 2020",
                    Genre = "Simulator",
                    ReleaseDate = new DateTime(2018, 11, 19)
                },
                new Game()
                {
                    Name = "The Witcher 4",
                    Genre = "RPG",
                    ReleaseDate = new DateTime(2015, 05, 18)
                },
                new Game()
                {
                    Name = "Destroy All Humans! 2",
                    Genre = "Action",
                    ReleaseDate = new DateTime(2020, 07, 28)
                }
            };
        }

        public List<Game> GetAllGames()
        {
            return _games;
        }

        public List<Game> GetPageGames(int page, int size)
        {
            return _games.Page(page, size).ToList();
        }

        public int MaxPageCount(int size)
        {
            return _games.PageCount(size);
        }
    }
}
