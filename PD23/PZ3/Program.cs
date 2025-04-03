namespace PZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 5;

            Dog dog = new Dog("Buddy", 3);
            Animal animal = new Animal("Max", age);


            dog.MakeSound();
            dog.GivePaw();
            Console.WriteLine("-------------");
            animal.MakeSound();
            

            Dog dog1 = new Dog("Bella", 2);
            dog1.MakeSound();
            dog1.GivePaw();

            Animal animal1 = dog1;

            animal1.MakeSound();

            int a = 4;
            
            float b = 4;

            a = (int)b;


            Dog dog2 = (Dog)animal1;


        }
    }
}
