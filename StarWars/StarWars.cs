using System;

namespace StarWars
{
    public class Program
	{
		public static void Main()
		{
			Person leia = new Person("Leia", "Organa", "Rebel");
			Person han = new Person("Han","Solo","Rebel");
			Person darth = new Person("Darth", "Vader", "Imperial");
			Person luke = new Person("Luke", "Skywalker","Rebel");
			Person boba = new Person("Boba", "Fett", "Imperial");
			Ship xwing = new Ship ("X-Wing","Rebel","Fighter", 1);
			Ship falcon = new Ship("Millenium Falcon","Rebel", "Smuggling", 2);
			Ship tie = new Ship("Vader's Tie Fighter", "Imperial", "Fighter", 1);
			Ship slave = new Ship("Slave One", "Imperial", "Fighter", 1);
			Station DeathStar = new Station("Death Star", "Imperial", 2);
			Station RebelStation = new Station("Rebel Space Station", "Rebel", 1);
			tie.EnterShip(darth, 0);
			slave.EnterShip(boba, 0);
			falcon.EnterShip(han, 0);
			falcon.EnterShip(leia,1);
			DeathStar.EnterStation(tie, 0);
			DeathStar.EnterStation(slave, 1);
			RebelStation.EnterStation(falcon, 1);
			RebelStation.Report();
			DeathStar.Report()

			Console.WriteLine("May the Force be with You!");		
			
		}
	
	}
	class Person
	{
		private string firstName;
		private string lastName;
		private string alliance;
		public Person(string firstName, string lastName, string alliance)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.alliance = alliance;
		}

		public string FullName
		{
			get
			{
				return this.firstName + " " + this.lastName;
			}

			set
			{
				string[] names = value.Split(' ');
				this.firstName = names[0];
				this.lastName = names[1];
			}
		}
	}


	class Ship
	{
		private Person[] passengers;
		public Ship(string name, string alliance, string type, int size)
		{
			this.Type = type;
			this.Alliance = alliance;
			this.Name = name;
			this.passengers = new Person[size];
		}

		public string Name
		{
			get;
			set;
		}

		public string Type
		{
			get;
			set;
		}

		public string Alliance
		{
			get;
			set;
		}

		public string Passengers
		{
			get
			{
				foreach (var person in passengers)
				{
					Console.WriteLine(String.Format("{0}", person.FullName));
				}

				return "That's Everybody!";
			}
		}
		public void EnterShip(Person person, int seat)
			{
				this.passengers[seat] = person;
			}
		
		public void ExitShip(int seat)
		{
			this.passengers[seat] = null;
		}

	}
	class Station 
	{
    	private Ship[] ships;
		public Station(string name, string alliance, int spaces)
		{ 
		this.Name = name;
		this.Alliance = alliance;
		this.ships = new Ship[spaces];
		}	

		public string Name
		{
			get;
			set;
		}

		public string Alliance
		{
			get;
			set;
		}

	
		public string spaces
		{
			get;
			set;
		}

		public void Report()
        {
            foreach (Ship ship in spaces)
            {
                Console.WriteLine("Ship: ");
                Console.WriteLine(ship.Name);
				Console.WriteLine("Passengers: ");
                Console.WriteLine(ship.Passengers);
            }
        }
	

		public void EnterStation(Ship ship, int space)
		{
			this.ships[space] = ship;
		}

		public void ExitStation(Ship ship, int space)
		{
			this.ships[space] = null;
		}
	}
	
}



