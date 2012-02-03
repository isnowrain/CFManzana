using System;
using System.Collections.Generic;
using System.Text;

using CoreFoundation;
using CFManzana;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFManzana by iSn0wra1n");

            iDevice dev = new iDevice();

            Console.WriteLine(dev.CopyValue("Device Activation State: " + "ActivationState"));
            
        }
    }
}
