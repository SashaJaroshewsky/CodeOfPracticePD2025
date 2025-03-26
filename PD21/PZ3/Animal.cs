
namespace PZ3
{
    abstract class Animal
    {
        public int Age { get; set; }
        public Animal(int age)
        {
            Age = age;
        }
        public abstract void Voice();
    }
}
