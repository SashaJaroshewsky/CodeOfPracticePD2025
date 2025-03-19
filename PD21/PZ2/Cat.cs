namespace PZ2
{
    internal class Cat : Animal
    {
        public Cat(int year) : base(year)
        {
        }

        public sealed override void Voice()
        {
            Console.WriteLine("Кіт м'явкає");
        }

        public void Hiss()
        {
            Console.WriteLine("Тік шипить");
        }
    }
}
