//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------
using System.Collections.Generic;
using System;
namespace AdapterExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Plug plug = new Plug("1");
            PlugAdapter plugAdapter = new PlugAdapter(plug);
            plugAdapter.On();
            plugAdapter.Off();
            Console.WriteLine(plugAdapter.GetStatus());
            WashingMachine washingMachine = new WashingMachine("590");
            washingMachine.On();
            washingMachine.Off();
            Console.WriteLine(washingMachine.GetStatus());
            Bulb bulb = new Bulb("1");
            bulb.On();
            bulb.Off();
            Console.WriteLine(bulb.GetStatus());
            List <ISmartDevice> smartDevices = new List<ISmartDevice>();
            smartDevices.Add(plugAdapter);
            smartDevices.Add(washingMachine);
            smartDevices.Add(bulb);
            
            
        }
    }
}

