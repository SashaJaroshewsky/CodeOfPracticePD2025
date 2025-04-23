using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Switch
    {
        private bool _ifActive;
        private ISwitcheable _switcheable;

        public Switch(ISwitcheable door)
        {
            _switcheable = door;
            _ifActive = false;
        }

        public void OnSwitch()
        {
            if (_ifActive)
            {
                Off();
                _ifActive = false;
            }
            else
            {
                On();
                _ifActive = true;
            }
        }


        private void On()
        {
            _switcheable.Activate();
        }
        private void Off()
        {
           _switcheable.Deactivate();
        }
    }
}
