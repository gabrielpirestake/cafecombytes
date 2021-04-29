using System;
using DesignPatterns.Creational.Abstract_Factory;
using DesignPatterns.Creational.Factory_Method;
using DesignPatterns.Creational.Singleton;

namespace DesignPatterns
{
    class Program
    {
        readonly static string[] mediumDogBreeds = new string[]
        {
                    "English Foxhound",
                    "German Pinscher",
                    "Shetland Sheepdog"
        };
        readonly static string[] mediumDogNames = new string[]
        {
                "Bud",
                "Tutti",
                "Miney"
        };
        readonly static string[] bigDogBreeds = new string[]
            {
                "Labrador",
                "Golden",
                "Rottweiler"
            };
        readonly static string[] bigDogNames = new string[]
        {
                "Filó",
                "Tissico",
                "Rex"
        };

        static void Main(string[] args)
        {
            while (true)
            {
                string text = "\n1 - Abstract Factory\n";
                text += "2 - Factory Method\n";
                text += "3 - Singleton\n";
                Console.WriteLine(text);
                var designPattern = Enum.Parse<DesignPattern>(Console.ReadLine());
                switch (designPattern)
                {
                    case DesignPattern.AbstractFactory:
                        var mediumDogName = mediumDogNames[new Random().Next(0, 3)];
                        var mediumDogBreed = mediumDogBreeds[new Random().Next(0, 3)];
                        VeterinaryCare.CreateTicket(Size.Medium, mediumDogName, mediumDogBreed).Attend();

                        var bigDogName = bigDogNames[new Random().Next(0, 3)];
                        var bigDogBreed = bigDogBreeds[new Random().Next(0, 3)];
                        VeterinaryCare.CreateTicket(Size.Big, bigDogName, bigDogBreed).Attend();
                        break;
                    case DesignPattern.FactoryMethod:
                        var sqlCn = DbFactory.Database(DataBase.SqlServer)
                                                               .CreateConnector("minhaCS")
                                                               .Connect();

                        sqlCn.ExecuteCommand("select * from tabelaSql");
                        sqlCn.Close();

                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("");

                        var oracleCn = DbFactory.Database(DataBase.Oracle)
                                                                  .CreateConnector("minhaCS")
                                                                  .Connect();

                        oracleCn.ExecuteCommand("select * from tabelaOracle");
                        oracleCn.Close();
                        break;
                    case DesignPattern.Singleton:
                        var log1 = CustomLog.Instance();
                        log1.Write("Café ");
                        var log2 = CustomLog.Instance();
                        log2.Write("com ");
                        var log3 = CustomLog.Instance();
                        log3.Write("Bytes");
                        Console.WriteLine(CustomLog.Instance().Read());
                        if((log1 == log2) && (log1 == log3))
                            Console.WriteLine("Mesmo Objeto");
                        else
                            Console.WriteLine("Algo de errado não está certo... =/");
                        CustomLog.Instance().Clear();
                        break;
                    default:
                        Console.WriteLine("Informe uma opção valida.");
                        break;
                }
            }
        }
    }

    public enum DesignPattern
    {
        AbstractFactory = 1,
        FactoryMethod = 2,
        Singleton = 3
    }
}
