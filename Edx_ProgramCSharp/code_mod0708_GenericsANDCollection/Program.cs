using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod0708_GenericANDCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateArrayList();
            // CreateHashtable();
            // CreateGenericList();
            CreateGenericDictionary();

        } // end main

        #region Collections
        static void CreateArrayList()
        {
            // Create a new ArrayList collection.
            ArrayList beverages = new ArrayList();

            // Create some items to add to the collection.
            Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Robusta", "Indonesia");

            // Add the items to the collection
            // Items are implicitly cast to the Object type when you add them.
            beverages.Add(coffee1);
            beverages.Add(coffee2);
            beverages.Add(coffee3);

            // Retrieve from the collection
            // Since in collections, everything is cast into System.Object class
            // Therefore, Items must be explicitly cast bck to their original type
            Coffee firstCoffee  = (Coffee)beverages[0];
            Coffee secondCoffee = (Coffee)beverages[1];

            OutputCollection(beverages);
        } // end static method CreateArrayList

        static void OutputCollection(ArrayList beverages)
        {
            // Iterating Over a List Collection
            foreach (Coffee coffee in beverages)
            {
                Console.WriteLine("Bean type:         {0}", coffee.Bean);
                Console.WriteLine("Country of origin: {0}", coffee.CountryOfOrigin);
                Console.WriteLine("Strength (1-5):    {0}", coffee.Strength);
            }
        }

        static void CreateHashtable()
        {
            // Create a new Hashtable collection
            Hashtable ingredients = new Hashtable();

            // Add some key/value pairs to the collection.
            //              Key: Item Name  Value: Ingredients
            ingredients.Add("Cafe au Lait", "Coffee, Milk");
            ingredients.Add("Cafe Mocha",   "Coffee, Milk, Chocolate");
            ingredients.Add("Cappuccino",   "Coffee, Milk, Foam");
            ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            ingredients.Add("Macchiato",    "Coffee, Milk, Foam");

            OutputHashtable(ingredients);

        }

        static void OutputHashtable(Hashtable hTable)
        {
            // Check whether a key exists
            if (hTable.ContainsKey("Cafe Mocha")) // it is safe to check each key when the specific key-value pairs is query
            {
                // Retrieve the value associated with a key.
                Console.WriteLine("The ingredients of a Cafe Mocha are: {0}", hTable["Cafe Mocha"]);
                Console.WriteLine();
            }

            // Iterating Over a Dictionary Collection
            foreach (string key in hTable.Keys)
            {
                Console.WriteLine("The ingredients of a {0} are {1}", key, hTable[key]);
            } // end foreach loop

        } // end static method OutputHashtable 
        #endregion

        #region GenericCollections
        static void CreateGenericList()
        {
            // Create string objects
            // Note: String vs string vs System.String
            //       They all mean the same in this case
            string s1 = "Latte";
            string s2 = "Espresso";
            string s3 = "Americano";
            string s4 = "Cappuccino";
            string s5 = "Mocha";

            // Add the items to a strongly-typed collection List<T>
            var coffeeBeverages = new List<String>();

            coffeeBeverages.Add(s1);
            coffeeBeverages.Add(s2);
            coffeeBeverages.Add(s3);
            coffeeBeverages.Add(s4);
            coffeeBeverages.Add(s5);
            
            // Write the collection to a console window
            foreach (String coffeeBeverage in coffeeBeverages)
            {
                Console.WriteLine(coffeeBeverage);
            } // end foreach loop

            // ......

            // Create Coffee objects
            Coffee coffee1 = new Coffee(4, "Arabica", "Columnbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Robusta", "Indonesia");

            // Add the items to a strongly-typed collection
            var hotBeverages = new List<Coffee>();

            hotBeverages.Add(coffee1);
            hotBeverages.Add(coffee2);
            hotBeverages.Add(coffee3);

            // Write the collection to a console window
            foreach (Coffee beverage in hotBeverages)
            {
                Console.WriteLine(beverage.Bean);
            } // end foreach loop
        } // end method CreateGenericList()

        static void CreateGenericDictionary()
        {
            // USing the Dictionary<TKey, TValue> Class
            // Create a new dictionary of strings with string keys
            var coffeeCodes = new Dictionary<String, String>();

            // Add some entries to the dictionary
            coffeeCodes.Add("CAL", "Cafe Au Lait");
            coffeeCodes.Add("CSM", "Cinammon Spice Mocha");
            coffeeCodes.Add("ER",  "Expresso Romano");
            coffeeCodes.Add("RM",  "Raspberry Mocha");
            coffeeCodes.Add("IC",  "Iced Coffee");

            /*
                 // This statement would result in an ArgumentException becase the key already exist
                 // coffeeCodes.Add("IC", "Instant Coffee"); 
             */

            // To retrieve the value associated with a key, you can use the 
            // This will throw a KeyNotFoundException if the key does not exist
            Console.WriteLine("The value associated with the key \"CAL\" is {0}", coffeeCodes["CAL"]);

            // Alternatively, you can use the TryGetValue method.
            // This returns true if the key exists and false if the key does not exist
            string csmValue = "";

            if (coffeeCodes.TryGetValue("CSM", out csmValue))
            {
                Console.WriteLine("The value associated with the key \"CSM\" is {0}", csmValue);
            }
            else
            {
                Console.WriteLine("The key \"CSM\" was not found");
            } // end if-else
        } // end method CreateGenericDictionary

        #endregion
    } // end class
} // end namespace
