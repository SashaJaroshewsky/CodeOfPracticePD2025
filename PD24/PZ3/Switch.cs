using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3
{
     public class Switch
    {
        private bool _isOn;
        private ISwitcheable sw;

      
        public Switch (ISwitcheable switcheable)
        {
            _isOn = false;
            sw = switcheable;
        }


        public void SwitchOn() 
        {
            if (_isOn)
            {
                _isOn = false;
                sw.Activate();
            }
            else
            {
                _isOn = true;
                sw.Deactivate();
            }
        }
    }
}
