namespace PZ2
{
    internal class Dog : Animal
    {
        public Dog(int year): base(year)
        {
            Console.WriteLine("Викликався дочірній конструктор");
        }

        public void Voice()
        {
            Console.WriteLine("Собака гавкає");
        }

        public void GiveHand()
        {
            Console.WriteLine("Собака дав лапу");
        }
    }
}
