using System;

namespace IteratorCompositePatterns
{
    public class DinerMenu: IMenu
    {
        const int MAX_ITEMS = 6;
        int _numberOfItems = 0;
        MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Veg BLT", "Fakin' bacon", true, 2.99m);
            AddItem("BLT", "Real bacon", false, 2.99m);
            AddItem("Soup of the day", "Brothy", false, 3.29m);
            AddItem("Hotdog", "Onions and mustard", false, 3.05m);
        }

        void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);

            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.Error.WriteLine("Sorry, menu full!");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}