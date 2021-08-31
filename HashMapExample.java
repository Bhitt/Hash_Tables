/*
	JAVA SPECIFIC:
		Java has two hash table classes: HashTable and HashMap. In general, you should use a HashMap.
		-HashTable doesn't allow null keys or values, while HashMap does.
		-HashTable is synchronized to prevent multiple threads from accessing it at once; a HashMap isn't.
*/

import java.util.HashMap; // import the HashMap class

HashMap<String, Integer> lightBulbHoursOfLight = new HashMap();

// Add an item
lightBulbHoursOfLight.put("incandescent", 1200);
lightBulbHoursOfLight.put("compact flourescent", 10000);
lightBulbHoursOfLight.put("LED", 50000);

// Access an item
lightBulbHoursOfLight.get("LED");

// Remove an item
lightBulbHoursOfLight.remove("incandescent");

// Remove all items
lightBulbHoursOfLight.clear();

// Get the size of the map
lightBulbHoursOfLight.size();

// Loop through keys
for(String i : lightBulbHoursOfLight.keySet()){
	System.out.println(i);
}

// Loop through values
for(Integer i : lightBulbHoursOfLight.values()){
	System.out.println(i);
}