/* 
	Solution 1 
	
	Insert all the values of the array into a hashmap for quick index lookup.
	Loop through the array using the current value to search the hashmap for a possible missing value.
		missing value = target - current value.
	If found, return the current index and use the map to get the missing value's index.
*/


/* 
	Time Complexity: O(n)
	Space Complexity: O(n)
*/


import java.util.Arrays;

class Solution {
    public int[] twoSum(int[] nums, int target) {
        // answer
        int[] result = {-1,-1};
       
        // create a map to handle index searching
        HashMap<Integer, Integer> map = new HashMap<>();
        for(int i = 0; i < nums.length; i++){
            map.put(nums[i], i);
        }
        
        // loop through array finding a pair that sums
        for(int i = 0; i < nums.length; i++){
            int missing = target - nums[i];
            if(map.containsKey(missing)){
                if(map.get(missing) != i){
                    result[0] = i;
                    result[1] = map.get(missing);
                    return result;
                }
            }
        }

        // ERROR RESULT
        return result;
        
    }
    
}

/*
	LEETCODE RESULTS

	Runtime: 3 ms, faster than 62.36% of Java online submissions for Two Sum.
	Memory Usage: 40.4 MB, less than 17.58% of Java online submissions for Two Sum.
*/