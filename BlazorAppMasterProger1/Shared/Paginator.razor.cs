using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace BlazorAppMasterProger1.Shared
{
    public partial class Paginator
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Parameter] public int MaxPageNumber { get; set; }

        [Parameter] public EventCallback<int> ChangePageHandler { get; set; }

        [Parameter] public int CurrentPageNumber { get; set; }

        //int _currentPageNumber;

        /*protected async override Task OnInitializedAsync()
        {
            var rx_EndUri = new Regex(@"[1-9][0-9]*$");
            MatchCollection matches = rx_EndUri.Matches(NavigationManager.Uri);
            string str = matches.First().Value;
            bool isParsable = int.TryParse(str, out _currentPageNumber);
            CurrentPageNumber = _currentPageNumber;
        }*/

        void ChangePage(int pageNumber)
        {
            NavigationManager.NavigateTo("/list/" + pageNumber);
            //CurrentPageNumber = pageNumber;
            ChangePageHandler.InvokeAsync(pageNumber);
        }
    }
}
