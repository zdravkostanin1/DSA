// Check if array is a valid subsequence of another array

// Solution 1:
using System;
using System.Collections.Generic;

// Solution runs on O(N) time and O(1) space. 
// Uses a for loop
public class Program {
  public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
    int seqIdx = 0;

    for (int i = 0; i < array.Count; i++) {
        if (seqIdx == sequence.Count) {
            break;
        }
        if (array[i] == sequence[seqIdx]) {
            // Move the pointer of the sequence to the next element in the sequence
            seqIdx++;
        }
    }

    // return as a boolean
    return seqIdx == sequence.Count;
  }
}

// Solution 2:

// Solution runs on O(N) time and O(1) space.
// Uses a while loop
public class Program {
  public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
    int arrIdx = 0;
    int seqIdx = 0;

    while (arrIdx < array.Count && seqIdx < sequence.Count) {
        if (array[arrIdx] == sequence[seqIdx]) {
            // Move the pointer to the next element in the sequence
            seqIdx++;
        }
        // in all other cases - continue moving the point of the array to the next element.
        arrIdx++;
    }
    
    // return as a boolean
    return seqIdx == sequence.Count;
  }
}
