using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

using BlazorAppMasterProger1.Model;

namespace BlazorAppMasterProger1.Shared
{
    public partial class GameListTable
    {
        [Parameter] public List<Game> Games { get; set; }

        [CascadingParameter] public AppStyle AppStyle { get; set; }

        bool displayButtons = false;

        string _currentTableStyle = "table-striped";

        void DeleteGame(Game game)
        {
            _gameToBeDeleted = game;
            _confirmation.Show();
        }

        protected override void OnInitialized()
        {
            Console.WriteLine($"1. OnInitialized(). Games count {Games?.Count}.");
        }

        protected override void OnParametersSet()
        {
            Console.WriteLine($"2. OnParametrSet(). Games count {Games?.Count}.");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine($"3. OnAfterRender(bool firstRender). First render? {firstRender}.");
        }

        protected override bool ShouldRender()
        {
            return true;
        }

        Confirmation _confirmation;

        Game _gameToBeDeleted;

        void OnConfirm()
        {
            Games.Remove(_gameToBeDeleted);
            _confirmation.Hide();
            _gameToBeDeleted = null;
        }

        void OnCancel()
        {
            _confirmation.Hide();
            _gameToBeDeleted = null;
        }

        void ChangeTableStyle(ChangeEventArgs e)
        {
            _currentTableStyle = e.Value.ToString();
        }
    }
}
