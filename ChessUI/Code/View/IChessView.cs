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
        public interface IChessView
        {
            // Методы для обновления состояния View

            /// <summary>
            /// Обновляет доску в соответствии с текущим состоянием игры.
            /// </summary>
            /// <param name="board">Текущее состояние доски.</param>
            void UpdateBoard(Board board);

            /// <summary>
            /// Устанавливает текущего игрока (белые или черные).
            /// </summary>
            /// <param name="player">Текущий игрок.</param>
            void SetCurrentPlayer(Player player);

            /// <summary>
            /// Показывает подсказки возможных ходов для выбранной фигуры.
            /// </summary>
            void ShowHighlights();

            /// <summary>
            /// Скрывает подсветку возможных ходов.
            /// </summary>
            void HideHighlights();

            /// <summary>
            /// Показывает сообщение о завершении игры.
            /// </summary>
            /// <param name="message">Сообщение о результате игры (например, "Победили белые").</param>
            void ShowGameOverMessage(string message);

            /// <summary>
            /// Показывает меню паузы.
            /// </summary>
            void ShowPauseMenu();

            /// <summary>
            /// Перезапускает игру (очищает состояние View).
            /// </summary>
            void RestartGame();

            // События для уведомления Presenter'a о пользовательских действиях

            /// <summary>
            /// Возникает, когда пользователь кликает на клетку доски.
            /// </summary>
            event Action<Position> OnSquareClicked;

            /// <summary>
            /// Возникает, когда пользователь выбирает действие в меню GameOver.
            /// </summary>
            event Action<Option> OnGameOverOptionSelected;

            /// <summary>
            /// Возникает, когда пользователь выбирает действие в меню Pause.
            /// </summary>
            event Action<Option> OnPauseOptionSelected;

            /// <summary>
            /// Возникает, когда пользователь нажимает клавишу Escape.
            /// </summary>
            event Action OnEscapeKeyPressed;
        }
    }
}
