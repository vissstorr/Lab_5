using System.Collections.Generic;
namespace Lab_5
{
    public class GameMemory
    {
        private Board _board;
        private Stack<Memento> _memento;

        public GameMemory()
        {
            _board = new Board();
            _memento = new Stack<Memento>();
        }
        public void BackUp()
        {
            _memento.Push(_board.SaveState());
        }

        public void Undo()
        {
            if (_memento.Count == 0) return;
            _board.RestoreState(_memento.Pop());
        }
        public Board Board()
        {
            return _board;
        }
    }
}
