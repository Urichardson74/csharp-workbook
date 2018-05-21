using System;
using System.Collections.Generic;

namespace Rainforest {
    class Program {
        static void Main (string[] args) {
            Company rainforest = new Company ("Rainforest, LLC");

            string[] cities = new string[] { "Austin", "Houston", "Dallas", "San Antonio" };
            string[] items = new string[] {"Banana", "Toothpaste", "Baseball", "Laptop"};

            foreach (var city in cities) {
                Warehouse warehouse = new Warehouse (city, 1);
                rainforest.warehouses.Add (warehouse);
            }

            for (int i = 0; i < rainforest.warehouses.Count; i++) {
                Warehouse warehouse = rainforest.warehouses[i];
                Container container = new Container ($"{warehouse.location}-1", i + 1);
                rainforest.warehouses[i].containers.Add (container);
            }

            for (int i = 0; i < rainforest.warehouses.Count; i++) {
                Container container = rainforest.warehouses[i].containers[0];
                Item item = new Item (items[i], i);
                container.items.Add (item);
            }

            Console.WriteLine ("Hello World!");
        }
    }

    class Company {
        public string name;
        public List<Warehouse> warehouses;

        public Company (string name) {
            this.name = name;
            this.warehouses = new List<Warehouse> ();
        }
    }

    class Warehouse {
        public string location;
        public int size;
        public List<Container> containers;

        public Warehouse (string location, int size) {
            this.location = location;
            this.size = size;
            this.containers = new List<Container> ();
        }

    }

    class Container {
        public List<Item> items;
        public int size;
        public string id;

        public Container (string id, int size) {
            this.id = id;
            this.size = size;
            this.items = new List<Item> ();
        }

    }

    class Item {
        public string name;
        public double price;

        public Item (string name, double price) {
            this.name = name;
            this.price = price;
        }

    }
}
