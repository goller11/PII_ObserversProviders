//Autor: @guillevogel11

using System;
using Monitor;
using Reporter;
using Temp;

namespace Program {
    class Program {
        static void Main (string[] args) 
        {
            TemperatureReporter reporter1 = new TemperatureReporter ();
            TemperatureMonitor monitor1 = new TemperatureMonitor ();

            reporter1.Subscribe(monitor1);
            monitor1.GetTemperature();
        }
    }
}
