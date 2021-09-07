/* 
	Solution 1 
	
	1) Create a frequency table the size of valid numbers (0 through 101).
	2) For each number in nums, increment freqTable[i] by one.
	3) Loop through the freq table, if freqTable[i] > 0, store the value at freqTable[i] in temp. 
		Then, set freqTable[i] to prev and set prev = freqTable[i] + temp.
	4) For each number in nums, nums[i] = freqTable[nums[i]]
*/


/* 
	Time Complexity: O(n) time
	Space Complexity: O(1), since we have a constant size for the freq table
*/

public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        // Frequency Table for valid nums[i]
        int[] freqTable = new int[101];
        int prev = 0;
        int temp = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            freqTable[nums[i]]++;
        }
        
        for (int i = 0; i < 101; i++) {
            if(freqTable[i] != 0){
                temp = freqTable[i];
                freqTable[i] = prev;
                prev = freqTable[i] + temp;
            }
        }
    
        for (int i = 0; i < nums.Length; i++){
            nums[i] = freqTable[nums[i]];
        }
    
        return nums;
        
    }
}

/*
	LEET CODE RESULTS

	Runtime: 236 ms, faster than 95.14% of C# online submissions for How Many Numbers Are Smaller 
		Than the Current Number.
	Memory Usage: 32 MB, less than 97.71% of C# online submissions for How Many Numbers Are Smaller 
		Than the Current Number.
*/