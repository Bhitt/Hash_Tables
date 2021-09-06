/* 
	Solution 1 
	
	Use a boolean array to map characters (jewels) that are valid. Check the stone characters against
	the boolean array to find if they are valid and incremement a counter if they are.

	Note: the boolean array is assuming ASCII characters (128)
*/


/* 
	Time Complexity: O(j + s), where j and s are the lengths of the strings jewels and stones
	Space Complexity: O(1)
*/

public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        // the number of jewels in your stones bag
        int count = 0;
        
        // Use a boolean array for the characters that are jewels
        bool[] j = new bool[128];
        
        // Insert the jewels into the boolean array
        for (int i = 0; i < jewels.Length; i++){
            j[jewels[i]] = true;
        }
        
        // Loop through the stones and increment if they are in the bool array
        for (int i = 0; i < stones.Length; i++){
            if(j[stones[i]]) count++;
        }
        
        // Return the count of jewels
        return count;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 126 ms, faster than 6.92% of C# online submissions for Jewels and Stones.
	Memory Usage: 23.4 MB, less than 99.79% of C# online submissions for Jewels and Stones.
*/