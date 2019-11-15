// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Staticblockinitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.SingletonLink.SingletonExample
{
    public static class Staticblockinitialization
    {
        public static double ToFarenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        public static double ToCelcius(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
    }
}
