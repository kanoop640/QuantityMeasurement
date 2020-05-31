﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Kilogram.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Kilogram
    {
        /// <summary>
        /// Variable for kilogram value
        /// </summary>
        double kilogram;
        public Kilogram(double kilogram)
        {
            this.kilogram = kilogram;
        }
        public double GetValue()
        {
            return this.kilogram;
        }
    }
}
