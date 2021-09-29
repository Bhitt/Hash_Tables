/* 
	Solution 1 
	
	Enter in each path into a hashmap<start, destination>. Then pick any path to start at and follow
	until you reach a city that is not in the hashmap.
*/


/* 
	Time Complexity: O(n) time, where n is the number of paths
	Space Complexity: O(n)
*/

public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        // HashMap for quick lookup
        Dictionary<string, string> route = new Dictionary<string, string>();
        
        // Enter in paths to hashmap
        foreach(List<string> path in paths){
            route.Add(path[0], path[1]);
        }
        
        // Traverse path starting from paths[0]
        string city = paths[0][0];
        while(route.ContainsKey(city)){
            city = route[city];
        }
        
        // Final destination
        return city;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 104 ms, faster than 99.22% of C# online submissions for Destination City.
	Memory Usage: 27.4 MB, less than 45.74% of C# online submissions for Destination City.
*/