using System;
using System.Collections.Generic;
/// NUMBER OF PAIRS IN ARRAY THAT SUM TO A PARTICULAR VALUE

// SOLUTION 1: O(N^2) time complexity and O(1) space complexity.
public class Program {
  public static int[] TwoNumberSum(int[] array, int targetSum) {
    for (int i = 0; i != array.Length; i++) {
        for (int j = i + 1; j != array.Length; j++) {
            if (array[i] + array[j] == targetSum) {
                int[] array2 = {array[i], array[j]};
                return array2;
            }
        }
    }  
    return new int[0];
  }
}

// SOLUTION 2: O(N) time complexity and O(N) space complexity.
public class Program {
  public static int[] TwoNumberSum(int[] array, int targetSum) {
    Dictionary<int, bool> dic = new Dictionary<int, bool>();

    for (int i = 0; i != array.Length; i++) {
        if (dic.ContainsKey(targetSum - array[i])) {
            return new int [] {array[i], targetSum - array[i]};
        }
        else {
            dic[array[i]] = true;
        }
    }

    return new int[0];
  }
}
