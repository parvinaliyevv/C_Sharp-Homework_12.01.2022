using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class PetShop
    {
        public string Name { get; set; }
        public CatHouse[] CatHouses { get; set; } = new CatHouse[0];

        public PetShop(string name) => Name = name;



        public void AddCatHouse(CatHouse catHouse)
        {
            if (catHouse != null)
            {
                var newCatHouses = new CatHouse[CatHouses.Length + 1];

                for (int i = 0; i < CatHouses.Length; i++)
                {
                    newCatHouses[i] = CatHouses[i];
                }

                newCatHouses[CatHouses.Length] = catHouse;

                CatHouses = newCatHouses;
            }
        }

        public void ShowCatHouse()
        {
            foreach (var catHouse in CatHouses)
            {
                catHouse.ShowAllCats();
            }
        }

        public void ShowAllStatistics()
        {
            int resultPrice = default, resultMealQuantity = default;

            foreach (var catHouse in CatHouses)
            {
                foreach (var cat in catHouse.Cats)
                {
                    resultPrice += cat.Price;
                    resultMealQuantity += cat.MealQuantity;
                }
            }

            Console.WriteLine("Total price: {0}\nTotal meal quantity: {1}", resultPrice, resultMealQuantity);
        }
    }
}
