using System;
					
public class Program
{
	public static void Main()
	{
		Car blueCar = new Car("blue");
		Car yellowCar = new Car("yellow");
		Car greyCar = new Car("grey");
		Car greenCar = new Car("green");
		Car redCar = new Car("red");
		Car blackCar = new Car("black");
		string carChoice = "";
		
		Garage smallGarage = new Garage(2);
		Garage largeGarage = new Garage(4);

		Console.WriteLine("Please pick a car color: blue, yellow, grey, green red or black")
		carChoice = Console.ReadLine().ToLower();

		

	

		
		smallGarage.ParkCar(blueCar, 0);
		smallGarage.ParkCar(yellowCar, 1);
		largeGarage.ParkCar(greenCar, 0);
		largeGarage.ParkCar(greyCar, 1);
		largeGarage.ParkCar(redCar, 2);
		largeGarage.ParkCar(blackCar, 3);
		
		Console.WriteLine(smallGarage.Cars);
		Console.WriteLine(largeGarage.Cars);
	}

class Car
	{
    public Car(string initialColor)
    	{
    		Color = initialColor;
    	}
    
   	 public string Color { get; private set; }
	}

class Garage
	{
    	private Car[] cars;
    
   		public Garage(int initialSize)
   		{
    		Size = initialSize;
	   		this.cars = new Car[initialSize];
    	}
    
    	public int Size { get; private set; }
    
    	public void ParkCar (Car car, int spot)
    	{
        	cars[spot] = car;
    	}
    
    	public string Cars {
			get {
				for (int i = 0; i < cars.Length; i++)
				{
				if (cars[i] != null) {
					Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
				}
				}
				return "That's all for this Garage!";
		}
	}

}



