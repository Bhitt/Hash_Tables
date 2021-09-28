/* 
	Solution 1 
	
	Iterate over the sentence, seting a bit for each character. If all 26 bits are set, (ie the 
	count is 67108863), then every character was present at least once.
*/


/* 
	Time Complexity: O(n) time, where n is the number of letters in the sentence
	Space Complexity: O(1), we use a single int to act as a bit vector
*/

public class Solution {
    public bool CheckIfPangram(string sentence) {
        // Bit Vector in place of a hashset
        int count = 0;
        
        // Loop through string and add a '1' bit at the index of the char
        foreach(char c in sentence){
            count |= (1 << c - 'a'); // Set bit
        }
        
        // Check if the total is correct, 26 '1' bits in a row
        return (count == 67108863);
    }
}

/*
	LEET CODE RESULTS

	Runtime: 72 ms, faster than 86.16% of C# online submissions for Check if the Sentence Is 
	Pangram.

	Memory Usage: 22.6 MB, less than 79.46% of C# online submissions for Check if the Sentence Is 
	Pangram.
*/