/* 
    Solution 1 
    
    Add numbers to a hashset. Then count the length of sequences from the start of those sequences 
    using the hashset for quick lookup. Note, when searching for the start of sequences, use the
    hashset to avoid duplicate values/sequences in nums. For instance, if there are three 0's in 
    nums, you only want to calculate the sequence 0 - 1 - 2- 3 one time rather than 3 times. This
    saves a lot of time potentially.
*/


/* 
    Time Complexity: O(n) 
    Space Complexity: O(n)
*/

public class Solution {
    public int LongestConsecutive(int[] nums) {
        // Length 0 case
        if(nums.Length == 0) return 0;
        
        // hash set for nums quick lookup
        HashSet<int> numSet = new HashSet<int>();
        foreach(int n in nums){
            numSet.Add(n);
        }
        
        // find sequence lengths
        int max = 1;
        int cur = 0;
        int key;
        foreach(int n in numSet){
            key = n;
            // only count sequence if starting from the front of sequence
            if(!(numSet.Contains(key-1))){
                cur = 1;
                key++;
                while(numSet.Contains(key)){
                    cur++;
                    key++;
                }
                max = cur > max ? cur : max;
            }
        }
        
        // Exit stage right
        return max;
    }
}

/*
    LEETCODE RESULTS

    Runtime: 194 ms, faster than 52.13% of C# online submissions for Longest Consecutive Sequence.
    Memory Usage: 37.4 MB, less than 31.59% of C# online submissions for Longest Consecutive 
        Sequence.
*/