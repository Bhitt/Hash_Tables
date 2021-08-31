/*
	We can reduce space usage by using a bit vector. The below code checks if all characters in a
	string are unique using a bit vector. Assuming all lowercase characters (a - z), this can be
	done with a single int.
*/

boolean isUniqueChars(String str){
	int checker = 0; // BIT VECTOR
	for (int i = 0; i < str.length(); i++){
		int val = str.charAt(i) - 'a';
		if((checker & (1 << val)) > 0){
			return false;
		}
		checker |= (1 << val);
	}
	return true;
}

/*
	A bit vector can also be used in the example of checking if a string is a permutation of a
	palindrome.

	When we see a letter, we map it to an integer between 0 and 26. Then we toggle the bit at that
	value. At the end of the iteration, we check that at most one bit in the integer is 1.
*/

boolean isPermutationOfPalindrome(String phrase){
	int bitVector = createBitVector(phrase);
	return bitVector == 0 || checkExactlyOneBitSet(bitVector);
}

int createBitVector(String phrase){
	int bitVector = 0;
	for(char c : phrase.toCharArray()){
		int x = getCharNumber(c);
		bitVector = toggle(bitVector, x);
	}
	return bitVector;
}

int toggle(int bitVector, int index){
	if(index < 0) return bitVector;

	int mask = 1 << index;
	if((bitVector & mask) == 0){
		bitVector |= mask;
	} else {
		bitVector &= ~mask;
	}
	return bitVector;
}

boolean checkExactlyOneBitSet(int bitVector){
	return (bitVector & (bitVector - 1)) == 0;
}