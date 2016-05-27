using System.Collections;

namespace IteratorCompositePatterns
{
    public class PancakeHouseMenu: IMenu
    {
        ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();

            AddItem("Pancake breakfast", "With maple syrup", true, 2.99m);
            AddItem("Extreme pancake breakfast", "Double... with maple syrup", true, 2.99m);
            AddItem("Blueberry pancakes", "Fresh fruit", true, 3.49m);
            AddItem("Waffles", "With a choice of blueberries or strawberries", true, 3.59m);
        }

        void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);
            _menuItems.Add(menuItem);
        }

        public Iterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }
    }
}