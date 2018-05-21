using System;
					
public class Program
{
	public static void Main()
	{
		Car blueCar = new Car("blue", 2);
		Car yellowCar = new Car("yellow", 4);
		Car greyCar = new Car("grey", 2);
		Car greenCar = new Car("green", 4);
		Car redCar = new Car("red", 2);
		Car blackCar = new Car("black", 4);
		Person jim = new Person("Jim");
		Person ron = new Person("Ron");
		Person sally = new Person("Sally");
		Person april = new Person("April");
		Person ann = new Person("Ann");
		Person steve = new Person("Steve");
		// string carChoice = "";
		
		Garage smallGarage = new Garage(2);
		Garage largeGarage = new Garage(4);

		// Console.WriteLine("Please pick a car color: blue, yellow, grey, green red or black");
		// carChoice = Console.ReadLine().ToLower();

		blueCar.EnterCar(jim);
		redCar.EnterCar(ron);
		greyCar.EnterCar(sally);
		blackCar.EnterCar(april);
		greenCar.EnterCar(ann);
		yellowCar.EnterCar(steve);

	
		
		//assigning cars to garages 
		smallGarage.ParkCar(blueCar, 0);
		smallGarage.ParkCar(yellowCar, 1);
		largeGarage.ParkCar(greenCar, 0);
		largeGarage.ParkCar(greyCar, 1);
		largeGarage.ParkCar(redCar, 2);
		largeGarage.ParkCar(blackCar, 3);
		
		Console.WriteLine(smallGarage.Cars);
		Console.WriteLine(largeGarage.Cars);
	}





	class Person
	{
    	public Person(string setname)
    	{
    		Name = setname;
    	}
    
   		public string Name { get; private set; }
	}
	class Car
	{
		public Person[] people;
    	public Car(string initialColor, int seats1)

    		{
			
    			Color = initialColor;
				Seats = seats1;
				this.people = new Person[seats1];
    		}

		public int Seats {get; private set;}
    
   	 	public string Color { get; private set; }

		public void EnterCar(Person person, int seat = -1)
        {
            if (seat < 0) { seat = people.Length; };
            people[seat] = person;
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
		
    		public string Cars 
			{
				get 
				{
					for (int i = 0; i < cars.Length; i++)
					{
		

						if (cars[i] != null)
                    	{
                        	Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
                        	for (int j = 0; j < cars[i].people.Length; j++) Console.WriteLine(String.Format("{0} is in car {1}", cars[i].people[j].Name, i));
                    	}

						return "That's all for this garage.";
			
					}
				}
			}			
		}
	}
}
	








