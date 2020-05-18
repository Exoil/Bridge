using Bridge;
using System;
using Xunit;

namespace BirdgeTest
{
    public class SwitchTest
    {
        [Theory]
        [InlineData(1,"Sony")]
        public void TrunOnRadioSwitch(int id, string name)
        {
            var radio = new Radio(id, name);
            Bridge.Button btn = new Bridge.Button(radio);

            Assert.True(btn.TurnOn().Equals($"On {radio} radio"));
           

        }


        [Theory]
        [InlineData(1, "Sony")]
        public void TrunOffRadioSwitch(int id, string name)
        {
            var radio = new Radio(id, name);
            Bridge.Button btn = new Bridge.Button(radio);

            Assert.True(btn.TurnOff().Equals($"Off {radio} radio"));
        }

        [Theory]
        [InlineData(2, "Samsung")]
        public void TrunOnTVSwitch(int id, string name)
        {
            var tv = new TV(id, name);
            Bridge.Button btn = new Bridge.Button(tv);

            Assert.True(btn.TurnOn().Equals($"On {tv} Tv"));


        }


        [Theory]
        [InlineData(2, "Samsung")]
        public void TrunOffTVSwitch(int id, string name)
        {
            var tv = new TV(id, name);
            Bridge.Button btn = new Bridge.Button(tv);

            Assert.True(btn.TurnOff().Equals($"Off {tv} Tv"));
        }
    }
}
