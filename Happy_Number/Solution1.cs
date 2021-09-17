/* 
	Solution 1 
	
	Insert each entry of the sequence into a list to avoid cycles. If the entry is already in the 
	list, return false. If the entry equals 1, return true.

	Note: We use a list as a HashSet since it performs faster in this case than the built-in HashSet.
*/

/* 
	Time Complexity: O(s), where s is the length of the sequence before ending or reaching a cycle
	Space Complexity: O(s)
*/

public class Solution {
    public bool IsHappy(int n) {
        // Store previous results in list to avoid cycles
        List<int> hs = new List<int>();
        int nextDig = 0;
        int nextEntry = 0;
        
        // Next number in sequence
        while(true){
            while(n>=1){
                nextDig = n%10; // Grab last digit
                nextEntry += nextDig * nextDig; // Add that digit squared
                n/=10; // remove last digit
            }
            if(nextEntry == 1) return true; // HAPPY NUMBER!
            
            if(hs.Contains(nextEntry)) return false; // Cycle found, not happy number
            
            hs.Add(nextEntry); // Add value to avoid cycles
            n = nextEntry;
            nextEntry = 0;
        }
        
        return false; // ERROR
    }
}

/*
	LEET CODE RESULTS

	Runtime: 40 ms, faster than 87.75% of C# online submissions for Happy Number.
	Memory Usage: 15.1 MB, less than 95.80% of C# online submissions for Happy Number.
*/