using PZ3.DoorAndSwich;

namespace PZ3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();

            Switch swich = new Switch(door);

            swich.Activate();
            swich.Deactivate();

            Robot robot = new Robot();

            Switch switch2 = new Switch(robot);

            switch2.Activate();
            switch2.Deactivate();
        }
    }
}
