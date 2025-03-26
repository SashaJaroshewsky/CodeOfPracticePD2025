
namespace PZ3.DoorAndSwich
{
    public class Switch
    {
        public ISwitchable switchable { get; set; }

        public Switch(ISwitchable switchable)
        {
           this.switchable = switchable;
        }

        public void Activate()
        {
            switchable.On();
        }

        public void Deactivate()
        {
            switchable.Off();
        }
    }
}