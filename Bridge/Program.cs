using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bridge");
            Switch btn = new Button(new Radio(1,"Sony"));

            Console.WriteLine(btn.TurnOn());
            Console.WriteLine(btn.TurnOff());

            btn = new Button(new TV(2, "Philips"));

            Console.WriteLine(btn.TurnOn());
            Console.WriteLine(btn.TurnOff());

            Console.WriteLine("End");

            Console.ReadLine();
        }
    }
}
