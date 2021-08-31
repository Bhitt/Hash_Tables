/*
	Using an array, that operates like a hash table, map a character to its frequency.
	Assuming ASCII, the size of the array should be 128.

	The below code uses a frequency table to check if two strings are permutations of each other.
*/

boolean permutation(String s, String t){
	if (s.length() != t.length()) return false; // They should be the same length

	int[] letters = new int[128]; // FREQUENCY TABLE (ASCII)
	for (int i = 0; i < s.length(); i++){
		letters[s.charAt(i)]++;
	}

	for (int i = 0; i < t.length(); i++){
		letters[t.charAt(i)--];
		if(letters[t.charAt(i)] < 0){
			return false;
		}
	}
	return true;
}