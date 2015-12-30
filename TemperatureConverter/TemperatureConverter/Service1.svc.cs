using System;
using System.ServiceModel;

namespace TemperatureConverter
{
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public int c2f(int c)
        {
            int f = (c * 9 / 5) + 32;
            return (f);
        }

        public int f2c(int f)
        {
            int c = (f - 32) * 5 / 9;
            return (c);
        }
    }
}
