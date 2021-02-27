using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppMasterProger1.Helpers
{
    public class GameHandler
    {
        public RSIOptions Choose { get; set; }

        public RSIOptions WinCondition { get; set; }

        public RSIOptions LooseCondition { get; set; }

        public string Image { get; set; }

        public GameState GameResult(GameHandler opponenet)
        {
            if (Choose == opponenet.Choose)
                return GameState.Draw;
            if (LooseCondition == opponenet.Choose)
                return GameState.Loss;
            return GameState.Victory;
        }
    }
}
