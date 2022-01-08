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

            decimal value = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}" , value);

            Console.ReadLine();




        }
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carVAlue = 100.0M;
            // Someday i might look up the car
            //online webservice to get more
            //accurate value.
            return carVAlue;
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