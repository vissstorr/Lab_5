namespace Lab_5
{
    public class Memento
    {
        private char[,] _state;

        public Memento(char[,] state)
        {
            _state = state;
        }

        public char[,] GetState()
        {
            return _state;
        }
    }
}
