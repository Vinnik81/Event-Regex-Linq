using System;
using System.Threading;

namespace ConsoleApp1
{

    class HungryCatEventArgs : EventArgs
    {
        public DateTime Date { get; set; }
    }
    class Cat
    {
        public event EventHandler<HungryCatEventArgs> Hungry;
        public string Name { get; set; }
        public float Weight { get; set; }

        private int hunger;

        public Cat(string name, float weight)
        {
            Name = name;
            Weight = weight;
            Hunger = 0;
        }

        public int Hunger
        {
            get { return hunger; }
            set
            {

                hunger = value;

                if (hunger >= 100)
                {
                    Console.WriteLine("Покорми");
                    Hungry?.Invoke(this, new HungryCatEventArgs { Date = DateTime.Now });
                }
                else
                {
                    Console.WriteLine("Я не голоден");
                }
            }
        }

        public void Eat(float foodKq)
        {
            Weight += foodKq;
            Hunger = 0;
        }

    }
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public void FeedCat(object sender, HungryCatEventArgs e)
        {
            if (sender is Cat cat)
            {
                Console.WriteLine($"{cat.Name} is hungry at {e.Date}. Weight: {cat.Weight} . {Name} give food");

                if (cat.Weight < 5)
                    cat.Eat(1);
                else
                    cat.Eat(6.9f);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Barsik", 2);

            Person person1 = new Person("Farid");
            Person person2 = new Person("Denis");

            cat.Hungry += person2.FeedCat;
            cat.Hungry += person1.FeedCat;

            /////////////////////////////////////////////////////
            ///
            //
            ///
            ///////////////////////////////////////////////////////


            while (true)
            {
                Thread.Sleep(200);
                cat.Hunger++;
            }
        }
    }
}