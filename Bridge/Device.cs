using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Device
    {
        private Int32 id;
        public String name { get; set; }

        public abstract String On();

        public abstract String Off();

        public Device(Int32 id, String name)
        {
            this.id = id;
            this.name = name;
        }


        public override bool Equals(object obj)
        {
            if(obj is Device)
            {
                var device = obj as Device;
                return this.id.Equals(device.id);
            }
            return false;
        }

        public override string ToString()
        {
            return $"{this.name}";
        }
    }

    public class Radio : Device
    {
        public Radio(Int32 id, String name) : base(id, name) { }

        public override String Off()
        {
            return $"Off {this.ToString()} radio";
        }

        public override String On()
        {
            return $"On {this.ToString()} radio";
        }
    }


    public class TV : Device
    {
        public TV(Int32 id, String name) : base(id, name) { }

        public override String Off()
        {
            return $"Off {this.ToString()} Tv";
        }

        public override String On()
        {
            return $"On {this.ToString()} Tv";
        }
    }
}
