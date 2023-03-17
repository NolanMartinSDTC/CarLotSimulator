using System;
namespace CarLotSimulator
{
	public class Car
	{
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

		public Car()
		{
		}

        //Custom Constructor
        public Car(int year, string make, string model, bool driveable, string engineNoise, string honkNoise)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = driveable;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        }
        public int Year { get; set; }
		public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDriveable { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"The car engine goes: {EngineNoise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"The car honk goes: {HonkNoise}");
        }

        
    }

    
}

