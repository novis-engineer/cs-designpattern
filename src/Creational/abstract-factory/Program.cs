using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using static System.Console;

namespace Dp.Creational.AbstractFactory
{
    class Program
    {
        private const string MercedesFactory = "MercedesFactory";
        private const string PorscheFactory = "PorscheFactory";
        private const string VolvoFactory = "VolvoFactory";

        private const string ConfigurationFilePathRelative = "./configuration.json";
        static void Main(string[] args)
        {
            var factoryKey = args.Length <= 0 ? PorscheFactory : args[0];
            var autoFactory = LoadFactory(factoryKey);

            WriteLine("---- ---- SPORTS CAR ---- ----");
            var sportsCar = autoFactory.CreateSportsCar();
            sportsCar.TurnOn();
            sportsCar.TurnOff();

            WriteLine();
            WriteLine("---- ---- LUXURY CAR ---- ----");
            var luxuryCar = autoFactory.CreateLuxuryCar();
            luxuryCar.TurnOn();
            luxuryCar.TurnOff();

            WriteLine();
            WriteLine("---- ---- ECONOMY CAR ---- ----");
            var economyCar = autoFactory.CreateEconomyCar();
            economyCar.TurnOn();
            economyCar.TurnOff();

            WriteLine();
            ReadKey();
        }

        static IAutoFactory LoadFactory(string factoryKey)
        {
            var factoryMap = JsonConvert.DeserializeObject<IDictionary<string, string>>(File.ReadAllText(ConfigurationFilePathRelative));
            if (!factoryMap.TryGetValue(factoryKey, out var fullyQualifiedFactoryName))
                fullyQualifiedFactoryName = PorscheFactory;

            return Assembly.GetExecutingAssembly().CreateInstance(fullyQualifiedFactoryName) as IAutoFactory;
        }
    }
}
