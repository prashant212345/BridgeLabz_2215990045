using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class AnimalHierarchy
    {
        static void Main()
        {
            Animal d = new Dog("Buddy", 3);
            Animal c = new Cat("Whiskers", 2);
            Animal b = new Bird("Tweety", 1);

            d.MakeSound();
            c.MakeSound();
            b.MakeSound();
        }
    }
    class Animal {
        public string Name { get; set; }
        public int Age {  get; set; }
        public Animal(string name, int age){
            Name = name;
            Age = age;
        }
        public virtual void MakeSound() {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog : Animal {
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound() {
            Console.WriteLine($"{Name}, the dog, barks!");
        }
    }
    class Cat : Animal {
        public Cat(string name, int age) : base (name, age) { }
        public override void MakeSound() {
            Console.WriteLine($"{Name}, the cat, meows!");
        }
    }
    class Bird : Animal {
        public Bird(string name, int age) : base(name,age) { }
        public override void MakeSound() {
            Console.WriteLine($"{Name}, the bird, chirps!");
        }
    }
}
