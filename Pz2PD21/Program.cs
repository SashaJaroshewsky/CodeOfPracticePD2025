namespace Pz2PD21
{
    internal class Program
    {
        static void Main()
        {
            Cat cat = new Cat(1);
            Dog dog = new Dog(2);
            Tiger tiger = new Tiger(10);

            //dog.Voice();

            Animal animal = dog;

            //animal.Voice();


            //Cat cat = new Cat(1);

            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);
            animals.Add(tiger);
            

            foreach (var animal1 in animals)
            {
                animal1.Voice();
                if(animal1 is Dog dog1)
                    dog1.Voice();
            }
            

            //Animal animal = cat;

            ////Dog dog1 = (Dog)animal;

            //if(animal is Dog dog1)
            //{
            //    Console.WriteLine("це собака");
            //    dog1.GiveHand();
            //}

            //Dog? dog2 = animal as Dog;
            //dog2?.GiveHand();


            //dog.Voice();

            //Animal animal = new Dog(3);
            //animal.Voice();

            //Dog dog = (Dog)animal;
            //dog.Voice();
            ////Animal animal1 = new Cat(4);

            //float a = 5.5f;
            //int b = (int)a;

        }
    }
}
