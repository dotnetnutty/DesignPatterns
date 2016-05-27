using System;

namespace IteratorCompositePatterns
{
    public class Waitress
    {
        IMenu _pancakeHouseMenu;
        IMenu _dinerMenu;

        public Waitress(params int[] whatever)
        {

        }

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = _pancakeHouseMenu.CreateIterator();
            var dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);

            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = (MenuItem)iterator.Next();
                Console.Write(menuItem.Name + ", ");
                Console.Write(menuItem.Price + ", ");
                Console.WriteLine(menuItem.Description + ".");
            }
        }
    }
}