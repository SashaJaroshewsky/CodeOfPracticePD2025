namespace LB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();

            Light light = new Light();
            
            Switch switch1 = new Switch(light);

            switch1.TurnOn(); // The door is open.
            switch1.TurnOn(); // The door is closed.

        }
    }
}
