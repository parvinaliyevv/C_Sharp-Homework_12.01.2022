using System;
using System.Timers;

namespace homework
{
    internal class Cat
    {
        public Cat(string nickname, string gender, sbyte age, ushort price)
        {
            Nickname = nickname;
            Gender = gender;
            Age = age;
            Price = price;
            Event.Elapsed += BusyOff;
        }

        public string Nickname { get; set; }
        public string Gender { get; set; }
        public sbyte Age { get; set; }

        public int Price { get; set; }
        public short Energy { get; set; } = 70;
        public short MealQuantity { get; set; }

        private string Busy { get; set; } = "Free";

        private Timer Event { get; set; } = new();



        public void BusyOff(Object source, ElapsedEventArgs e)
        {
            Busy = "Free";
            Event.Stop();

            if (Energy <= 0)
            {
                Console.WriteLine("The cat is tired and went to sleep");
                System.Threading.Thread.Sleep(1000);
                Sleep();
            }
        }

        public void Eat()
        {
            if (Busy != "Free") return;

            Busy = "Eat";
            Event.Interval = 5000;

            Energy += 60;
            Price += 20;
            MealQuantity++;

            if (Energy > 100) Energy = 100;
            else if (Energy <= 0) Energy = 0;

            Event.Start();
        }

        public void Sleep()
        {
            if (Busy != "Free") return;

            Busy = "Sleep";
            Event.Interval = 10000;

            Energy += 80;

            if (Energy > 100) Energy = 100;
            else if (Energy <= 0) Energy = 0;

            Event.Start();
        }

        public void Play()
        {
            if (Busy != "Free") return;

            Busy = "Play";
            Event.Interval = 7000;

            Energy -= 50;

            if (Energy > 100) Energy = 100;
            else if (Energy <= 0) Energy = 0;

            Event.Start();
        }

        public void Show()
        {
            Console.WriteLine(String.Format("Nickname: {0,-10} | Age: {1,-5}", Nickname, Age));
            Console.WriteLine("Meal Quantity: {0}", MealQuantity);
            Console.WriteLine("Gender: {0}", Gender);
            Console.WriteLine("Energy: {0}", Energy);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Busy: {0}", Busy);
        }

    }
}
