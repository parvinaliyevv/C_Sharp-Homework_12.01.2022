using System;

namespace homework
{
    internal class CatHouse
    {
        public Cat[] Cats { get; set; } = new Cat[0];

        public void AddCat(Cat cat)
        {
            if (cat != null)
            {
                var newCats = new Cat[Cats.Length + 1];

                for (int i = 0; i < Cats.Length; i++)
                {
                    newCats[i] = Cats[i];
                }
                newCats[Cats.Length] = cat;

                Cats = newCats;
            }
        }

        public void DelCat(in string nickname)
        {
            foreach (var item in Cats)
            {
                if (item.Nickname == nickname)
                {
                    var newCats = new Cat[Cats.Length - 1];

                    for (int i = 0; i < Cats.Length; i++)
                    {
                        if (Cats[i].Nickname == nickname) continue;
                        newCats[i] = Cats[i];
                    }

                    Cats = newCats;
                    break;
                }
            }

        }

        public Cat GetCat(in string nickname)
        {
            foreach (var cat in Cats)
            {
                if (cat.Nickname == nickname) return cat;
            }

            return null;
        }

        public void ShowAllCats()
        {
            foreach (var cat in Cats)
            {
                cat.Show();
            }
        }

    }
}
