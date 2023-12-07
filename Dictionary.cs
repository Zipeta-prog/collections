using System;
using System.Collections.Generic; 

class Dict {

		static public void Main () {
		
				// Creating a dictionary
		// using Dictionary<TKey,TValue> class
		Dictionary<int, string> My_dict = 
					new Dictionary<int, string>(); 
		
		My_dict.Add(1123, "Hello");
		My_dict.Add(1124, "World");
		
		// Using ContainsKey() method to check
		// the specified key is present or not
		if (My_dict.ContainsKey(1122)==true)
		{
			Console.WriteLine("Key is found...!!");
		}

		else
		{
			Console.WriteLine("Key is not found...!!");
		}
		
		if (My_dict.ContainsValue("Works fine!")==true)
		{
			Console.WriteLine("Value is found...!!");
		}

		else
		{
			Console.WriteLine("Value is not found...!!");
		}
	}
}
