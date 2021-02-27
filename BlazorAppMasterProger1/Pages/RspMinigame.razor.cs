using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

using BlazorAppMasterProger1.Helpers;

namespace BlazorAppMasterProger1.Pages
{
    public partial class RspMinigame : IDisposable
    {
        Timer _timer;

        GameHandler _opponenet;

        Random _rnd;

        int _imageIndex = 0;

        string _gameResultMessage = string.Empty;

        string _resultStyle = string.Empty;

        List<GameHandler> _games = new List<GameHandler>()
        {
            new GameHandler
            {
                Choose = RSIOptions.Paper,
                LooseCondition = RSIOptions.Scissors,
                WinCondition = RSIOptions.Rock,
                Image = "./Images/paper.png"
            },
            new GameHandler
            {
                Choose = RSIOptions.Rock,
                LooseCondition = RSIOptions.Paper,
                WinCondition = RSIOptions.Scissors,
                Image = "./Images/rock.png"
            },
            new GameHandler
            {
                Choose = RSIOptions.Scissors,
                LooseCondition = RSIOptions.Rock,
                WinCondition = RSIOptions.Paper,
                Image = "./Images/scissors.png"
            }
        };

        protected override void OnInitialized()
        {
            _opponenet = _games[0];
            _rnd = new Random(DateTime.Now.Millisecond);

            _timer = new Timer();
            _timer.Interval = 100;
            _timer.Elapsed += ElapsedTimer;
            _timer.Start();
        }

        async void ElapsedTimer(object sender, ElapsedEventArgs e)
        {
            _imageIndex = _rnd.Next(0, _games.Count);
            _opponenet = _games[_imageIndex];
            await InvokeAsync(StateHasChanged);
        }

        void SelectingHandler(GameHandler game)
        {
            _timer.Stop();
            GameState gameResult = game.GameResult(_opponenet);

            switch (gameResult)
            {
                case GameState.Victory:
                    _gameResultMessage = "Поздравляю!";
                    _resultStyle = "success";
                    break;
                case GameState.Loss:
                    _gameResultMessage = "ЛОХ!!!";
                    _resultStyle = "danger";
                    break;
                case GameState.Draw:
                    _gameResultMessage = "Оба лохи";
                    _resultStyle = "primary";
                    break;
                default:
                    break;
            }
        }

        void ResetGame()
        {
            _timer.Start();
            _gameResultMessage = string.Empty;
            _resultStyle = string.Empty;
        }

        public void Dispose()
        {
            if (_timer != null)
                _timer.Dispose();
        }
    }
}
