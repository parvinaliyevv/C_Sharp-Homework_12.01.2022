using System;
using System.Threading;
using homework;

var petShop = new PetShop("Zoo");

petShop.AddCatHouse(new CatHouse());
petShop.CatHouses[0].AddCat(new Cat("Bob", "Male", 7, 700));

petShop.CatHouses[0].GetCat("Bob")?.Play();


petShop.ShowAllStatistics();
Console.ReadKey();

while (true)
{
    Console.Clear();

    petShop.CatHouses[0].GetCat("Bob")?.Eat();
    // petShop.CatHouses[0].GetCat("Bob").Play();

    petShop.ShowCatHouse();

    Thread.Sleep(1000);
}
