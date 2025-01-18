using libraryManagementSystem;

/*UserInterface userInterface = new();

userInterface.MainMenu();*/

internal abstract class Animal
{
  public string Name { get; set; }
  public int Age { get; set; } 

  protected Animal(string name, int age) 
  {
    Name = name;
    Age = age;
  }
  public abstract void MakeSound();
}

internal class Dog : Animal
    {
        public Dog(string name, int age) 
            : base(name, age) 
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

internal class Cat : Animal
    {
        public Cat(string name, int age) 
            : base(name, age) // Calling the base class constructor
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }



