/* 
	Solution 1 
	
	1) Enter the morse code letter representations into a hashmap for quick lookup
	2) Keep a hashset for the transformations built from each word
	3) Use a stringbuilder when creating transformations for fast appends
	4) Foreach word in words
		Map each character to its morse code representation. Append that string to the 
		transformation. After mapping all characters, add the transformation string to the hashset.
	5) Return the number of unique strings in the hashset (Count).
*/


/* 
	Time Complexity: O(C), the total number of characters in all the input words
	Space Complexity: O(S), the unique number of transformation strings saved to the hashset
*/

public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        // HashMap for Morse Code representation
        string[] morse = new string[] {".-","-...","-.-.","-..",".","..-.",
                                       "--.","....","..",".---","-.-",".-..",
                                       "--","-.","---",".--.","--.-",".-.",
                                       "...","-","..-","...-",".--","-..-",
                                       "-.--","--.."};
        
        // HashSet for transformations
        HashSet<string> hs = new HashSet<string>();
        
        // StringBuilder for quick appends
        StringBuilder sb = new StringBuilder();
        
        // For each word in words
        foreach(string s in words){
            // Add the morse code representations of each character in the word
            foreach(char c in s){
                sb.Append(morse[c - 'a']);
            }
            
            // Add the transformation to the hashset
            hs.Add(sb.ToString());
            
            // Clear the contents of StringBuilder
            sb.Clear();
        }
        
        // Return the count of unique transformations
        return hs.Count;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 88 ms, faster than 91.84% of C# online submissions for Unique Morse Code Words.
	Memory Usage: 25.2 MB, less than 74.83% of C# online submissions for Unique Morse Code Words.
*/