namespace PZ2
{
    internal class Program
    {
        static void Main()
        {
            Dog dog = new Dog(12);


            Cat cat = new Cat(11);

            dog.Voice();

            Animal animal = dog;

            Console.WriteLine("+++++++++++++++++++++++=");
            animal.Voice();

            
            if (animal is Dog dog1)
            {
                //Cat dog1 = (Cat)animal;
                dog1.Voice();
            }

            Cat? cat2 = animal as Cat;

            cat2?.Voice();
            if (cat2 != null)
            {
                cat2.Voice();
            }

            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(animal);
            

            Animal[] ints = new Animal[100];
            ints[0] = cat;
            ints[1] = dog;

            Animal[] ints2 = new Animal[ints.Length+1];

            for (int i = 0; i<ints.Length;i++)
            {
                ints2 [i] = ints[i];
            }

            ints2[2] = animal;

           

            foreach (Animal animal1 in animals)
            {
                if (animal1 is Dog dog2)
                    dog2.Voice();
                if (animal1 is Cat cat1)
                    cat1.Voice();
            }




        }
    }
}
