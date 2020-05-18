using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Switch
    {
        protected Device device;

        public Switch(Device device)
        {
            this.device = device;
        }

        public abstract String TurnOn();
        public abstract String TurnOff();
    
    }

    public class Button : Switch
    {
        public Button(Device device): base(device)
        {

        }
        public override String TurnOff()
        {
            return device.Off();
        }

        public override String TurnOn()
        {
            return device.On();
        }
    }

}
