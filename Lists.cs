using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		// adding elements using add() method
		var primeNumbers = new List<int>();
		primeNumbers.Add(2);
		primeNumbers.Add(3);
		primeNumbers.Add(5);
		primeNumbers.Add(7);
		
		Console.WriteLine("No of elelemts: "+ primeNumbers.Count);

		var cities = new List<string>();
		cities.Add("Nairobi");
    cities.Add("London");
    cities.Add("Khartoum");
    cities.Add(null);// nulls are allowed for reference type list

		
		Console.WriteLine("No of elelemts: " + cities.Count);

		// adding elements using collection initializer syntax
		var bigCities = new List<string>()                     {
                        "Nairobi",
                        "London",
                        "Khartoum",
                    };
		
		Console.WriteLine("No of elelemts: " + bigCities.Count);
		
		var students = new List<Student>() { 
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };
	
		Console.WriteLine("No of elelemts: " + students.Count);
	}
}

class Student{
	public int Id { get; set; }
	public string Name { get; set; }
}
