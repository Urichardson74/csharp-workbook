using System;
using System.Collections.Generic;

namespace RainForest 
{
    class Program 
    {

        static void Main (string[] args) 
        {
            
            Company rainforest = new Company ("Rainforest, LLC");
            Dictionary<string, string> index = new Dictionary<string, string>();
            string[] cities = new string[] { "Austin", "Houston", "Dallas", "San Antonio" };
            string[] items = System.IO.File.ReadAllLines(@"./items.txt");

            foreach (var city in cities) {
                rainforest.warehouses.Add (new Warehouse (city, 1));
                rainforest.warehouses.Add (new Warehouse (city, 2));
            }

            for (int i = 0; i < rainforest.warehouses.Count; i++) {
                Warehouse warehouse = rainforest.warehouses[i];
                Container container = new Container ($"{warehouse.location}-{i + 1}", i + 1);
                rainforest.warehouses[i].containers.Add (container);
            }

            for (int i = 0; i < rainforest.warehouses.Count; i++) {
                Container container = rainforest.warehouses[i].containers[0];
                Item item = new Item (items[i], i);
                container.items.Add (item);
                index.Add(item.name, container.id);
    
              
            }

            rainforest.GenerateManifest ();

         
            Console.WriteLine("Please enter an item name to see where it is stored");
            Console.WriteLine(index[Console.ReadLine()]);
            Console.WriteLine ("Hello World!");
            Console.ReadLine();
        }
    }

    class Company 
    {
        public string name;
        public List<Warehouse> warehouses;

        public Company (string name) {
            this.name = name;
            this.warehouses = new List<Warehouse> ();
        }

            public void GenerateManifest()
        {
            Console.WriteLine(this.name);
           
            foreach (Warehouse warehouse in this.warehouses)
            {
                Console.WriteLine(warehouse.location);
                foreach (Container container in warehouse.containers)
                {
                    Console.WriteLine(container.id);
                    foreach (Item item in container.items)
                    {
                        Console.WriteLine(item.name);
                    } 
                }
            }
        }
    }

    class Warehouse 
    {
        public string location;
        public int size;
        public List<Container> containers;

        public Warehouse (string location, int size) 
        {
            this.location = location;
            this.size = size;
            this.containers = new List<Container> ();
        }

    }

    class Container 
    {
        public List<Item> items;
        public int size;
        public string id;

        public Container (string id, int size) 
        {
            this.id = id;
            this.size = size;
            this.items = new List<Item> ();
        }

           public string AddItem(Item item)
        {
            if (this.items.Count < this.size)
            {
                this.items.Add(item);
                return $"Added {item.name}";
            }
            else
            {
                return "all full";
            }
        }
    }

    class Item 
    {
        public string name;
        public double price;

        public Item (string name, double price) {
            this.name = name;
            this.price = price;
        }
    }
    
}
