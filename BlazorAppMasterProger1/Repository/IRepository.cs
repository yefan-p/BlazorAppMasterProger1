using BlazorAppMasterProger1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppMasterProger1.Repository
{
    public interface IRepository
    {
        List<Game> GetAllGames();

        List<Game> GetPageGames(int page, int size);

        public int MaxPageCount(int size);
    }
}
