using System;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Creational.Abstract_Factory;
using DesignPatterns.Creational.Factory_Method;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using Microsoft.Extensions.DependencyInjection;

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

        static void Main()
        {
            string text = "================Design Patterns================";
            text += "\n1 - Abstract Factory\n";
            text += "2 - Factory Method\n";
            text += "3 - Singleton\n";
            text += "---\n";
            text += "4 - Adapter\n";
            text += "5 - Composite\n";
            text += "6 - Decorator\n";
            text += "---\n";
            text += "7 - Command\n";
            text += "8 - Observer\n";
            Console.WriteLine(text);
            var designPattern = Enum.Parse<DesignPattern>(Console.ReadLine());
            switch (designPattern)
            {
                //Creational
                case DesignPattern.AbstractFactory:
                    AbstractFactoryScenario();
                    break;
                case DesignPattern.FactoryMethod:
                    FactoryMethodScenario();
                    break;
                case DesignPattern.Singleton:
                    SingletonScenario();
                    break;
                //Structural
                case DesignPattern.Adapter:
                    AdapterScenario();
                    break;
                case DesignPattern.Composite:
                    CompositeScenario();
                    break;
                case DesignPattern.Decorator:
                    DecoratorScenario();
                    break;
                //Behavioral
                case DesignPattern.Command:
                    CommandScenario();
                    break;
                case DesignPattern.Observer:
                    ObserverScenario();
                    break;                
                default:
                    Console.WriteLine("Informe uma opção valida.");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }

        private static void ObserverScenario()
        {
            var joao = new Observer("João");
            var eduardo = new Observer("Eduardo");
            var bill = new Observer("Bill");

            var amazon = new StockExchange("Amazon", NextDecimal());
            var microsoft = new StockExchange("Microsoft", NextDecimal());

            amazon.Subscribe(joao);
            amazon.Subscribe(eduardo);

            microsoft.Subscribe(eduardo);
            microsoft.Subscribe(bill);

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Value = NextDecimal();
                microsoft.Value = NextDecimal();

                if (i == 1)
                {
                    amazon.UnSubscribe(eduardo);
                }
            }
        }
        public static decimal NextDecimal()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);
            return r / (decimal)100000.00;
        }

        private static void CommandScenario()
        {
            var user = new User();

            user.Add('+', 100);
            Console.ReadKey();
            user.Add('-', 50);
            Console.ReadKey();
            user.Add('*', 10);
            Console.ReadKey();
            user.Add('/', 2);
            Console.ReadKey();

            user.Undo(4);
            Console.ReadKey();

            user.TurnBack(3);
        }

        private static void CompositeScenario()
        {
            //Component
            var bolo = new CompositeProduct("Bolo");

            //Leaf
            var acucar = new ProductComposition("Açucar");
            var farinha = new ProductComposition("Farinha");
            var fermento = new ProductComposition("Fermento");
            var oleo = new ProductComposition("Oleo");
            var chocolate = new ProductComposition("Chocolate");
            var granulado = new ProductComposition("Granulado");
            var caldaChocolate = new ProductComposition("Calda de Chocolate");
            var leite = new ProductComposition("Leite");
            var cremeDeLeite = new ProductComposition("Creme de Leite");

            //Composite
            var massa = new CompositeProduct("Massa de bolo");
            massa.AddChild(acucar);
            massa.AddChild(farinha);
            massa.AddChild(oleo);
            massa.AddChild(fermento);
            massa.AddChild(leite);

            var cobertura = new CompositeProduct("Cobertura de chocolate para bolo");
            cobertura.AddChild(chocolate);
            cobertura.AddChild(acucar);
            cobertura.AddChild(granulado);
            cobertura.AddChild(caldaChocolate);
            cobertura.AddChild(cremeDeLeite);

            bolo.AddChild(massa);
            bolo.AddChild(cobertura);
            bolo.AddChild(bolo);
            bolo.ShowProducts(2);
        }

        private static void AdapterScenario()
        {
            var accountBr = new BankService(new Account());
            accountBr.Deposit();
            accountBr.Withdraw();

            var accountEx = new BankService(new AccountAdapter(new ExternalAccount()));
            accountEx.Deposit();
            accountEx.Withdraw();
        }

        private static void DecoratorScenario()
        {
            var economyCar = new EconomyCar();
            var economyCarWithDeluxeAccessories = new DeluxeAccessories(economyCar);

            var deluxeCar = new DeluxeCar();
            var deluxeCarWithBasicAccessories = new BasicAccessories(deluxeCar);
            var deluxeCarWithDeluxeAccessories = new DeluxeAccessories(deluxeCar);
            Console.WriteLine($"{economyCar.GetDescription()} - {economyCar.GetCost()}");
            Console.WriteLine($"{economyCarWithDeluxeAccessories.GetDescription()} - {economyCarWithDeluxeAccessories.GetCost()}");
            Console.WriteLine($"{deluxeCar.GetDescription()} - {deluxeCar.GetCost()}");
            Console.WriteLine($"{deluxeCarWithBasicAccessories.GetDescription()} - {deluxeCarWithBasicAccessories.GetCost()}");
            Console.WriteLine($"{deluxeCarWithDeluxeAccessories.GetDescription()} - {deluxeCarWithDeluxeAccessories.GetCost()}");
        }

        private static void SingletonScenario()
        {
            var log1 = CustomLog.Instance();
            log1.Write("Café ");
            var log2 = CustomLog.Instance();
            log2.Write("com ");
            var log3 = CustomLog.Instance();
            log3.Write("Bytes");
            Console.WriteLine(CustomLog.Instance().Read());
            if ((log1 == log2) && (log1 == log3))
                Console.WriteLine("Mesmo Objeto");
            else
                Console.WriteLine("Algo de errado não está certo... =/");
            CustomLog.Instance().Clear();
        }

        private static void FactoryMethodScenario()
        {
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
        }

        private static void AbstractFactoryScenario()
        {
            var mediumDogName = mediumDogNames[new Random().Next(0, 3)];
            var mediumDogBreed = mediumDogBreeds[new Random().Next(0, 3)];
            VeterinaryCare.CreateTicket(Size.Medium, mediumDogName, mediumDogBreed).Attend();

            var bigDogName = bigDogNames[new Random().Next(0, 3)];
            var bigDogBreed = bigDogBreeds[new Random().Next(0, 3)];
            VeterinaryCare.CreateTicket(Size.Big, bigDogName, bigDogBreed).Attend();
        }
    }

    public enum DesignPattern
    {
        AbstractFactory = 1,
        FactoryMethod = 2,
        Singleton = 3,
        Adapter = 4,
        Composite = 5, 
        Decorator = 6,
        Command = 7,
        Observer = 8
    }
}
