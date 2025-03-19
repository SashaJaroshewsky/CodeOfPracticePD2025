namespace PZ2
{
    internal class Animal
    {
        public int Year;

        public Animal(int year)
        {
            Year = year;
            Console.WriteLine("Викликався батьківський конструктор");
        }

        public virtual void Voice()
        {
            Console.WriteLine("Тварина видає звуки");
        }

    }
}
