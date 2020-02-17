using Bridge;
using System;
using Xunit;

namespace BirdgeTest
{
    public class SwitchTest
    {
        [Fact]
        public void TrunOnSwitch()
        {
            var radio = new Radio(1, "Sony");
            Bridge.Button btn = new Bridge.Button(radio);

            Assert.False(btn.TurnOn().Equals(String.Empty));
           

        }

        [Fact]
        public void TrunOffSwitch()
        {
            var radio = new Radio(1, "Sony");
            Bridge.Button btn = new Bridge.Button(radio);

            Assert.False(btn.TurnOff().Equals(String.Empty));
        }
    }
}
