using System;
using System.Collections.Generic;

namespace TicTacToe
{
    internal class Board
    {
        private readonly Random _random;
        public Square[] Squares { get; }

        public Board()
        {
            Squares = new Square[9];
            for (var i = 0; i < Squares.Length; i++)
            {
                Squares[i] = new Square();
            }

            _random = new Random();
        }

        public void Mark(string position)
        {
            var columnChar = position[0];
            var rowChar = position[1];
            var columnIndex = columnChar - 'a';
            var rowIndex = rowChar - '1';
            var index = rowIndex * 3 + columnIndex;
            Squares[index].Mark(true);
        }

        public void MarkRandom(bool isPlayer1)
        {
            var blankIndexes = FindBlankIndexes();
            var randomPositionInBlankIndexes = _random.Next(0, blankIndexes.Count);
            var randomIndex = blankIndexes[randomPositionInBlankIndexes];
            Squares[randomIndex].Mark(isPlayer1);
        }

        private List<int> FindBlankIndexes()
        {
            var blankIndexes = new List<int>();
            for (var i = 0; i < Squares.Length; i++)
            {
                if (Squares[i].IsEmpty())
                {
                    blankIndexes.Add(i);
                }
            }

            return blankIndexes;
        }
    }
}