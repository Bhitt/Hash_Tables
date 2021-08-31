/* 
	A set is like a hash map except it only stores keys, without values.

	Sets often come up when we're tracking groups of items—nodes we've visited in a graph, 
	characters we've seen in a string, or colors used by neighboring nodes. Usually, we're 
	interested in whether something is in a set or not
*/

HashSet<String> lightBulbs = new HashSet<>();

// Add an item
lightBulbs.add("incandescent");
lightBulbs.add("compact flourescent");
lightBulbs.add("LED");

// Check for an item
lightBulbs.contains("LED"); // true
lightBulbs.contains("halogen"); // false

// Remove an item
lightBulbs.remove("compact flourescent");

// Remove all items
lightBulbs.clear();

// HashSet size
lightBulbs.size();

// Loop through a HashSet
for(String i  : lightBulbs){
	System.out.println(i);
}