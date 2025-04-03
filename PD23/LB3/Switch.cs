using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    class Switch
    {
        private bool _isOn;
        private ISwitcheable _switcheable;
       

        public Switch(ISwitcheable door)
        {
            _switcheable = door;
            _isOn = false;
        }

        public void TurnOn()
        {
            if (_isOn)
            {
                _isOn = false;
                _switcheable.Deactivate();
                return;
            }

            _isOn = true;
            _switcheable.Activate();

        }
    }
}
