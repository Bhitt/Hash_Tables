/* 
	Solution 1 
	
	Use a frequence table to hold the count for each character. Then follow the given algorithm.
*/


/* 
	Time Complexity: O(n), where n is the length of the string
	Space Complexity: O(1)
*/

public class Solution {
    public string SortString(string s) {
        // StringBuilder for resulting string
        StringBuilder sb = new StringBuilder();
        
        // Freq Table for character lookup
        int[] freqTable = new int[26];
        
        // Enter the characters into the freq table
        foreach(char c in s){
            freqTable[c - 'a']++;
        }
        
        // Follow the given algorithm
        int count = s.Length;
        while(count > 0){
            // Increasing
            for(int i = 0; i < 26; i++){
                if(freqTable[i] > 0){
                    sb.Append((char) (i + 'a')); // Add the character
                    freqTable[i]--; // Decrement the frequency
                    count--; // Increment the total count
                }
            }
            // Decreasing
            for(int i = 25; i >= 0; i--){
                if(freqTable[i] > 0){
                    sb.Append((char) (i + 'a')); // Add the character
                    freqTable[i]--; // Decrement the frequency
                    count--; // Increment the total count
                }
            }
        }
        
        // Return the string
        return sb.ToString();
    }
}

/*
	LEET CODE RESULTS

	Runtime: 76 ms, faster than 95.56% of C# online submissions for Increasing Decreasing String.
	Memory Usage: 25.4 MB, less than 91.11% of C# online submissions for Increasing Decreasing 
		String.
*/