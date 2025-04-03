namespace PZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            Lightbulb lightbulb = new Lightbulb();

            Switch sw = new Switch(door);

            sw.SwitchOn();

            Switch sw2 = new Switch(lightbulb);

            sw2.SwitchOn();
            sw2.SwitchOn();
        }
    }
}
