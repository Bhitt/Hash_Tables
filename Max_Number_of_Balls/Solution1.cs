/* 
	Solution 1 
	
	Map the sum of digits to the amount of balls that have that same sum. Then find the max of those
	mappings.
*/


/* 
	Time Complexity: O() 
	Space Complexity: O()
*/

public class Solution {
    public int CountBalls(int lowLimit, int highLimit) {
        // Hash Table for count of balls in boxes
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        //
        for(int i = lowLimit; i <= highLimit; i++){
            int ballNumber = i;
            int boxNum = 0;
            while(ballNumber > 0){
                boxNum += ballNumber % 10;
                ballNumber /= 10;
            }
            if(!map.ContainsKey(boxNum)){
                map.Add(boxNum, 0);
            }
            map[boxNum]++;
        }
        
        int max = -1;
        foreach(KeyValuePair<int, int> kvp in map){
            max = Math.Max(max, kvp.Value);
        }
        
        return max;
    }
}

/*
	LEET CODE RESULTS

	Runtime: 56 ms, faster than 94.20% of C# online submissions for Maximum Number of Balls in a 
	Box.

	Memory Usage: 27.3 MB, less than 7.25% of C# online submissions for Maximum Number of Balls in 
	a Box.
*/