
namespace PZ3.DoorAndSwich
{
    class Robot:ISwitchable
    {
        public bool IsWork { get; set; }

        public void On()
        {
            IsWork = true;
            Console.WriteLine("Robot Work");
        }

        public void Off()
        {
            IsWork = false;
            Console.WriteLine("Robot Off");
        }
    }
}
