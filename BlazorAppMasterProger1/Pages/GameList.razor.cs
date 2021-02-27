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
    public partial class GameList
    {
        [Inject] IRepository _repository { get; set; }

        [Parameter] public string PageNumber { get; set; }

        Paginator _paginator;

        int _pageNumber;

        int _maxPageNumber;

        int _pageSize = 4;

        List<Game> _games { get; set; }

        protected async override Task OnInitializedAsync()
        {
            bool isParsable = int.TryParse(PageNumber, out _pageNumber);

            if (isParsable)
            {
                _games = _repository.GetPageGames(_pageNumber, _pageSize);
            }
            _maxPageNumber = _repository.MaxPageCount(_pageSize);
        }

        void PaginatorClick(int currentPage)
        {
            _games = _repository.GetPageGames(currentPage, _pageSize);
        }
    }
}
