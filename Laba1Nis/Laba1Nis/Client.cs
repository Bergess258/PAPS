using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Nis
{
    public class Client
    {
        static List<AbstractFactory> factories = new List<AbstractFactory>();
        public Client()
        {
            factories.Add(new SedanFactory("Фабрика Седаны", new Sedan()));
            factories.Add(new HatchbackFactory("Фабрика Седаны", new Hatchback()));
            factories.Add(new CoupeFactory("Фабрика Седаны", new Coupe()));
        }
        public List<AbstractFactory> getFactories()
        {
            return factories;
        }
    }
}
