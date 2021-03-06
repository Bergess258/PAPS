﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Nis
{
    
    public abstract class AbstractFactory
    {
        public Car Car;
        public string Name { get; set; }
        public AbstractFactory(string n, Car c)
        {
            Name = n;
            Car = c;
        }
        public Car Produce()
        {
            return Car;
        }
    }
    public class HatchbackFactory : AbstractFactory
    {
        public HatchbackFactory(string n, Hatchback c) : base(n, c)
        {
        }
    }
    public class SedanFactory : AbstractFactory
    {
        public SedanFactory(string n, Sedan c) : base(n, c)
        {
        }
    }
    public class CoupeFactory : AbstractFactory
    {
        public CoupeFactory(string n, Coupe c) : base(n, c)
        {
        }
    }
    public abstract class Car
    {
        static Random random = new Random();
        string Name { get; set; }
        int horsePower { get; set; }
        float fuelConsumption { get; set; }
        public Car()
        {
            Name = "";
            horsePower = random.Next(78, 150);
            fuelConsumption = random.Next(6, 17);
        }

        public virtual string Info()
        {
            return Name + " " + horsePower + " л.с. " +
                "Расход на 100км:" + fuelConsumption;
        }
    }

    public class Hatchback : Car
    {
        public override string Info()
        {
            return base.Info() + " Кузов: Универсал";
        }
    }

    public class Sedan : Car
    {
        public override string Info()
        {
            return base.Info() + " Кузов: Седан";
        }
    }
    public class Coupe : Car
    {
        public override string Info()
        {
            return base.Info() + " Кузов: Купе";
        }
    }
}
