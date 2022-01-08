namespace simpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "oldsmobile";
            myCar.Model = "cutlas supreme";
            myCar.Year = 1986;
            myCar.Color = "silver";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make, 
                myCar.Model, 
                myCar.Year,
                myCar.Color);
            Console.ReadLine();




        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


    }
}