using Switch.CharackterLogic;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();


            Switch sw = new Switch(new Door());

            sw.OnSwitch();
            sw.OnSwitch();

            Console.WriteLine("+++++++++++++");

            Switch sw2 = new Switch(new Light());

            sw2.OnSwitch();
            sw2.OnSwitch();

            Console.WriteLine("++++++++++++++");

            BaseCharacter baseCharacter = new Player("Вася", 100);

            Bullet bullet = new Bullet(10);

            bullet.Hit(baseCharacter);
        }
    }
}
