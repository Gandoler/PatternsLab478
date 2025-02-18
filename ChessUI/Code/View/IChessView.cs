using ChessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessUI.Code.View
{
    internal interface IChessView
    {
        event Action<Position> PieceSelected;
        event Action RestartRequested;
        event Action ExitRequested;

        void DrawBoard(Board board);
        void ShowPromotionMenu(Player player, Position from, Position to);
        void HidePromotionMenu();
        void ShowGameOver(Result result);
        void HideMenus();
        void SetCursor(Player player);
    }
}
