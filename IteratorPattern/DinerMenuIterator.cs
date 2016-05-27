namespace IteratorCompositePatterns
{
    public class DinerMenuIterator : Iterator
    {
        MenuItem[] _menuItems;
        int _position = 0;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (_position >= _menuItems.Length || _menuItems[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            var menuItem = _menuItems[_position];
            _position++;
            return menuItem;
        }
    }
}