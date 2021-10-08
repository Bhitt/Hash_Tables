/* 
	Solution 1 
	
	First, get the frequencies of each number by entering them into a hashmap.
	Next, enter the frequencies into a hashset.
	Finally, check if the set size is equal to the number of frequencies.
*/


/* 
	Time Complexity: O(n)
	Space Complexity: O(n)
*/

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        // Enter into freq table
        Dictionary<int, int> freq  = new Dictionary<int, int>();
        foreach(int num in arr){
            freq.TryAdd(num,0);
            freq[num]++;
        }
        
        // Enter frequencies into set of frequencies
        HashSet<int> freqfreq = new HashSet<int>(freq.Values);
        
        
        return freqfreq.Count == freq.Count;
    }
}

/*
	LEETCODE RESULTS

	Runtime: 88 ms, faster than 96.90% of C# online submissions for Unique Number of Occurrences.
	Memory Usage: 39.4 MB, less than 8.53% of C# online submissions for Unique Number of 
	Occurrences.
*/