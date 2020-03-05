using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    interface ICarFunction
    {
        CarFunction getFunction(string functionName);
    }
    class CarProxy :ICarFunction
    {
        List<CarFunction> carFunctions;
        CarData carData;
        public CarProxy()
        {
            carData = new CarData();
            carFunctions = new List<CarFunction>();
        }
        public CarFunction getFunction(string functionName)
        {
            CarFunction temp = carFunctions.FirstOrDefault(p => p.getFunction() == functionName);
            if (temp == null)
            {
                temp = carData.getFunction(functionName);
                carFunctions.Add(temp);
            }
            return temp;
        }
    }
    class CarData:ICarFunction
    {
        List<CarFunction> carFunctions = new List<CarFunction>();
        public CarData()
        {
            carFunctions.Add(new CarFunction("Дистанционный запуск двигателя"));
            carFunctions.Add(new CarFunction("Дистанционное управление с ключа"));
            carFunctions.Add(new CarFunction("Голосовое управление"));
            carFunctions.Add(new CarFunction("Отображение уровня топлива"));
        }
        public CarFunction getFunction(string functionName)
        {
            return carFunctions.FirstOrDefault(p => p.getFunction() == functionName);
        }
    }
    class CarFunction
    {
        string name;
        public CarFunction(string n)
        {
            name = n;
        }
        public string getFunction()
        {
            return name;
        }
    }
}
