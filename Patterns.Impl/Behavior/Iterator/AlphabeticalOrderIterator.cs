namespace Patterns.Impl.Behavior.Iterator
{
    // Конкретные Итераторы реализуют различные алгоритмы обхода. Эти классы
    // постоянно хранят текущее положение обхода.
    public class AlphabeticalOrderIterator : Def.Behavior.Iterator.Iterator
    {
        private WordsCollection _collection;

        // Хранит текущее положение обхода. У итератора может быть множество
        // других полей для хранения состояния итерации, особенно когда он
        // должен работать с определённым типом коллекции.
        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }
    }
}