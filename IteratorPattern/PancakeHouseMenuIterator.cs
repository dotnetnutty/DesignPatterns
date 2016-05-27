using System.Collections;

namespace IteratorCompositePatterns
{
    public class PancakeHouseMenuIterator : Iterator
    {
        ArrayList _menuItems;
        int _position = 0;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (_position >= _menuItems.Count || _menuItems[_position] == null)
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