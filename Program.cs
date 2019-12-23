using System;

namespace Lab01_OOP_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Based on the level of automation, driverless cars are divided in five categories.");

            // create objects for each child class of Driverlesscar and ManualCar classes.
            CompleteAutomation googleCar = new CompleteAutomation();
            googleCar.PrintModel();
            HighAutomation tesla = new HighAutomation();
            tesla.PrintModel();
            ConditionalAutomation ford = new ConditionalAutomation();
            ford.PrintModel();
            DriverAssistance jaguar = new DriverAssistance();
            jaguar.PrintModel();
            NoAutomation renault = new NoAutomation();
            renault.PrintModel();

            //array of objects from different classes
            DriverlessCar[] selfDCars =
            {
            new CompleteAutomation("Google Car", 2019, 120000,"Level 5",false),
            new HighAutomation("Tesla",2018,130000,"Level 4",400),
            new ConditionalAutomation("Ford",2018,80000,"Level 3",true)
            };

            //display the objects from the array
            Console.WriteLine(selfDCars[0]);
            Console.WriteLine(selfDCars[1]);
            Console.WriteLine(selfDCars[2]);
        }
    }
    #region Vehicle class
    // Base class Vehicle
    class Vehicle
    {
        private string make;
        private int year;
        private double price;
        public string Make { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string make, int year)
        {
            this.Make = make;
            this.Year = year;
        }
        public Vehicle(string make, int year, double price)
        {
            this.Make = make;
            this.Year = year;
            this.Price = price;
        }
        public virtual void PrintModel()
        {
            Console.WriteLine("This is a Vehicle class model");
        }
    }
    #endregion

    #region DriverlessCar class
    // child class inherits methods and attributes from Vehicle
    class DriverlessCar : Vehicle
    {
        private string automationLevel;
        public string AutomationLevel { get; set; }
        //assign default constructor to call objects without arguments
        public DriverlessCar()
        {

        }
        //constructor with base parameters + own parameters
        public DriverlessCar(string make, int year, double price, string automationLevel) : base(make, year, price)
        {
            this.AutomationLevel = automationLevel;
        }
        //override toString method to be reused on the child classes
        public override string ToString()
        {
            return string.Format("This type of vehicle is of: ");
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a DriverlessCar model");
        }
    }
    #endregion

    #region CompleteAutomation class
    class CompleteAutomation : DriverlessCar
    {
        private bool havePedals;
        bool HavePedals { get => havePedals; set => havePedals = value; }
        public CompleteAutomation()
        {
        }
        public CompleteAutomation(string make, int year, double price, string automationLevel, bool havePedals) : base(make, year, price, automationLevel)
        {
            this.HavePedals = havePedals;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("\nComplete Automation, with\nMake: {0},\nYear: {1},\nPrice: {2}.", Make, Year, Price);
        }

        public override void PrintModel()
        {
            Console.WriteLine("This is a CompleteAutomation model");
        }
    }
    #endregion

    #region HighAutomation class
    class HighAutomation : DriverlessCar
    {
        private int numberOfSensors;
        public int NumberOfSensors { get => numberOfSensors; set => numberOfSensors = value; }
        public HighAutomation()
        {

        }
        public HighAutomation(string make, int year, double price, string automationLevel, int numberOfSensors) : base(make, year, price, automationLevel)
        {
            this.numberOfSensors = numberOfSensors;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("\nHigh Automation, with\nMake: {0},\nYear: {1},\nPrice: {2}.", Make, Year, Price);
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a HighAutomation model");
        }
    }
    #endregion

    #region ConditionalAutomation class
    class ConditionalAutomation : DriverlessCar
    {
        private bool requireHumanInput;
        public bool RequireHumanInput { get => requireHumanInput; set => requireHumanInput = value; }
        public ConditionalAutomation()
        {

        }
        public ConditionalAutomation(string make, int year, double price, string automationLevel, bool requireHumanInput) : base(make, year, price, automationLevel)
        {
            this.requireHumanInput = requireHumanInput;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("\nConditional Automation, with\nMake: {0},\nYear: {1},\nPrice: {2}.", Make, Year, Price);
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a ConditionalAutomation model");
        }
    }
    #endregion

    #region ManualCar class
    class ManualCar : Vehicle
    {
        private string transmissionType;
        public string TransmissionType { get => transmissionType; set => transmissionType = value; }
        public ManualCar()
        {

        }
        public ManualCar(string make, int year, double price, string transmissionType) : base(make, year, price)
        {
            this.transmissionType = transmissionType;
        }

        public override void PrintModel()
        {
            Console.WriteLine("This is a ManualCar model");
        }
    }
    #endregion

    #region DriverAssistance class
    class DriverAssistance : ManualCar
    {
        private string assistFunctions;
        public string AssistFunctions { get => assistFunctions; set => assistFunctions = value; }
        public DriverAssistance()
        {

        }
        public DriverAssistance(string make, int year, double price, string transmissionType, string assistFunctions) : base(make, year, price, transmissionType)
        {
            this.assistFunctions = assistFunctions;
        }

        public override void PrintModel()
        {
            Console.WriteLine("This is a DriverAssistance model");
        }
    }
    #endregion

    #region NoAutomation class
    class NoAutomation : ManualCar
    {
        private string emissionType;
        public string Type { get => emissionType; set => emissionType = value; }
        public NoAutomation()
        {

        }
        public NoAutomation(string make, int year, double price, string transmissionType, string emissionType) : base(make, year, price, transmissionType)
        {
            this.emissionType = emissionType;
        }

        public override void PrintModel()
        {
            Console.WriteLine("This is a NoAutomation model");
        }
    }
    #endregion
}
