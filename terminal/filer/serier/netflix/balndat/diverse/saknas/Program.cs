/*
 * $Created by Nils Reberg
 * Date: 2019-02-03
 * Time: 17:03
 */
using System;
using System.Collections.Generic;
namespace Joppe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Petowner petowner = new Petowner();
            petowner.Add_animal(30);
            petowner.Menu();
        }
    }
    class Petowner
    {
        private Ball ball = new Ball();
        private List<Animal> animals = new List<Animal>();

        public void Menu()
        {
            int menu = 0;
            Console.WriteLine("Choose from among the options below.");
            Console.WriteLine("-----------------------------------------------------------------------");
            do
            {

                Console.WriteLine("");
                Console.WriteLine("1. Play with one of your animals.");
                Console.WriteLine("2. See what animals you have.");
                Console.WriteLine("3. Feed animal.");
                Console.WriteLine("4. Check your ball.");
                Console.WriteLine("5. Exit simulator.");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Fetch();
                        break;
                    case 2:
                        List_Of_Animals();
                        break;
                    case 3:
                        Feed();
                        break;
                    case 4:
                        Check_Ball();
                        break;
                    case 5:
                        Console.WriteLine("Program shutting down.");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            } while (menu != 5);
        }
        public void Add_animal(int amount)
        {
            string gender;
            int age;
            bool hungry;
            string name;
            string favorite_food;
            int animal_determine;
            List<string> favorite_foods = new List<string>() { "Chicken", "Beef", "Tuna", "Salmon", "Duck", "Sirloin" };
            List<string> male_names = new List<string>() { "Fido", "Rex", "Fluffy", "Charlie", "George", "Alfie" };
            List<string> female_names = new List<string>() { "Bella", "Poppy", "Molly", "Daisy", "Willow", "Ruby" };

            Random random = new Random();
            int loop = 0;
            do
            {
                gender = (random.Next(0, 2) == 1)
                    ? "Male"
                    : "Female";
                hungry = (random.Next(0, 2) == 1);
                favorite_food = favorite_foods[random.Next(0, favorite_foods.Count)];
                name = (gender == "Male")
                    ? male_names[random.Next(0, male_names.Count)]
                    : female_names[random.Next(0, female_names.Count)];
                age = random.Next(1, 12);
                animal_determine = random.Next(1, 4);
                Console.WriteLine(animal_determine);
                if (animal_determine == 1)
                {
                    animals.Add(new Dog(name, age, favorite_food, hungry, gender));
                }
                else if (animal_determine == 2)
                {
                    animals.Add(new Cat(name, age, favorite_food, hungry, gender));
                }
                else
                {
                    animals.Add(new Puppy(name, age, favorite_food, hungry, gender));
                }
                loop++;

            } while (loop < amount);
        }
        public void Fetch()
        {
            int animal_selection;
            Console.WriteLine("");
            Console.WriteLine("Choose from the list below what animal you would like to play with (hint: hungry animals aren't too playful): ");
            Console.WriteLine("");
            List_Of_Animals();
            animal_selection = int.Parse(Console.ReadLine());
            animal_selection--;
            animals[animal_selection].Interact(ball);
        }
        public void List_Of_Animals()
        {
            int index = 0;
            foreach (var animal in animals)
            {
                index++;
                Console.WriteLine("{0}. {1}", index, animal.ToString());
            }
        }
        public void Check_Ball()
        {
            if (ball.quality == 0)
            {
                Console.WriteLine("Oh no! Your ball is broken! Let's add a new one.");
                Console.WriteLine("");
                ball = new Ball();
            }
            else
            {
                Console.WriteLine(ball.ToString());
            }
        }
        public void Feed()
        {
            int animal_selection;
            string food;
            Console.WriteLine("");
            Console.WriteLine("Please select which animal you would like to feed from the list below: ");
            List_Of_Animals();
            animal_selection = int.Parse(Console.ReadLine());
            animal_selection--;
            Console.WriteLine("What would you like to feed the animal?");
            food = Console.ReadLine();
            animals[animal_selection].Eat(food);
        }


    }
    class Ball
    {
        int color_selection;
        public int quality;
        private List<string> colors = new List<String>() { "Red", "Yellow", "Blue", "Green", "Red", "Pink", };
        private string color;

        public Ball()
        {
            quality = 5;
            int index = 0;
            Console.WriteLine("Choose which color you want your ball to be: ");
            foreach (var x in colors)
            {
                index++;
                Console.WriteLine("{0}. {1}", index, x);

            }
            color_selection = int.Parse(Console.ReadLine());
            color_selection--;
            color = colors[color_selection];
        }
        public void Lower_quality(int damage)
        {
            quality = quality - damage;
        }
        public override string ToString()
        {
            return string.Format("Color: {0}, Quality: {1}", color, quality);
        }
    }
    abstract class Animal
    {
        protected int age;
        protected string name;
        protected string favorite_food;
        protected bool hungry;
        protected string hunger;
        protected string gender;
        protected string pronoun;

        public virtual void Interact(Ball ball)
        {
            if (hungry)
            {
                Console.WriteLine("{0} is hungry and does not want to play right now. Try feeding it.", name);
            }
            else
            {
                ball.Lower_quality(1);
                Console.WriteLine("{0} fetched the ball for you and had a good time, the ball did however wear down a bit.", name);
                hungry = true;
                hunger = "Hungry";
            }
            if (ball.quality < 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Your ball has been chewed up and is no longer useable :(");
            }
        }
        public void Eat(string food)
        {
            if (food == favorite_food)
            {
                Console.WriteLine("{0} ate {1}, it was delicious!", name, food);
                hungry = false;
                hunger = "Not hungry";
            }
            else
            {
                Hungry_animal();
            }

        }
        public virtual void Hungry_animal()
        {
            Console.WriteLine("{0}: *whines*", name);
            Console.WriteLine("{0} does not want to eat that.", name);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} years old, {2}. Favorite food is: {3}", name, age, gender, favorite_food);

        }

    }
    class Dog : Animal
    {
        public Dog(string _name, int _age, string _favorite_food, bool _hungry, string _gender)
        {
            name = _name;
            age = _age;
            favorite_food = _favorite_food;
            hungry = _hungry;
            gender = _gender;
            pronoun = (gender == "Male")
                ? "He"
                : "She";
            hunger = (hungry)
            ? "Hungry"
            : "Not hungry";

        }
        public override void Interact(Ball ball)
        {
            if (hungry)
            {
                Console.WriteLine("{0} is hungry and does not want to play right now. Try feeding it.", name);
            }
            else
            {
                ball.Lower_quality(2);
                Console.WriteLine("{0} fetched the ball for you and had a good time, the ball did however wear down a bit.", name);
                hungry = true;
                hunger = "Hungry";
            }
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} years old, {2}. Favorite food is: {3}. Dog. {4}", name, age, gender, favorite_food, hunger);
        }
    }
    class Cat : Animal
    {
        public Cat(string _name, int _age, string _favorite_food, bool _hungry, string _gender)
        {
            name = _name;
            age = _age;
            favorite_food = _favorite_food;
            hungry = _hungry;
            gender = _gender;
            pronoun = (gender == "Male")
                ? "He"
                : "She";
            hunger = (hungry)
                ? "Hungry"
                : "Not hungry";
        }

        public override void Hungry_animal()
        {
            Random random = new Random();
            base.Hungry_animal();
            Console.WriteLine("{0} is going out to try to find food on its own.", name);
            if (random.Next(0, 1) == 1)
            {
                Console.WriteLine("{0} found a mouse and ate it and is no longer hungry!", pronoun);
                hungry = false;
                hunger = "Not hungry";
            }
            else
            {
                Console.WriteLine("{0} didn't find anything. Try picking {1}'s favorite food next time!", pronoun, name);
            }
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} years old, {2}. Favorite food is: {3}. Cat. {4}", name, age, gender, favorite_food, hunger);
        }
    }
    class Puppy : Dog
    {
        public Puppy(string _name, int _age, string _favorite_food, bool _hungry, string _gender) : base(_name, _age, _favorite_food, _hungry, _gender)
        {

        }
        public override void Interact(Ball ball)
        {
            if (hungry)
            {
                Console.WriteLine("{0} is hungry and does not want to play right now. Try feeding it.", name);
            }
            else
            {
                ball.Lower_quality(1);
                Console.WriteLine("{0} fetched the ball for you and had a good time, the ball did however wear down a bit.", name);
                hungry = true;
                hunger = "Hungry";
            }
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} months old, {2}. Favorite food is: {3}. Puppy. {4}", name, age, gender, favorite_food, hunger);
        }
    }
}
