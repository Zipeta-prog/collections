namespace HashTable{
  class Hash1{
    // Create a Hashtable
Hash1 capitals = new Hash1();

// Add key-value pairs
capitals.Add("Person1", "Jane");
capitals.Add("Person2", "John");
capitals.Add("Person3", "Peris");

// Access a value by key
string capitalOfUK = (string)capitals["UK"];

// Remove a key-value pair
capitals.Remove("France");

// Iterate through the Hashtable
foreach (DictionaryEntry entry in capitals)
{
    Console.WriteLine(entry.Key + ": " + entry.Value);
}

  }
}
