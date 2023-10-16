import 'dart:math';

class Solution {
  List<int> numbersThatMakeTarget = [];
  int validAnswerCount = 0;

  List<int> twoSum(List<int> nums, int target) {
    if (pow(-10, 9) <= target && target <= pow(10, 9)) {
      if (2 <= nums.length && nums.length <= pow(10, 4)) {
        for (int i = 0; i <= nums.length; i++) {
          if (validAnswerCount >= 1) {
            break;
          }
          if (i != nums.length) {
            if (pow(-10, 9) <= nums[i] && nums[i] <= pow(10, 9)) {
              for (int j = i; j <= nums.length; j++) {
                if (validAnswerCount >= 1) {
                  break;
                }
                if (j != nums.length) {
                  if (nums[i] + nums[j] == target && i != j) {
                    numbersThatMakeTarget.add(i);
                    numbersThatMakeTarget.add(j);
                    validAnswerCount++;
                  }
                }
              }
            }
          }
        }
      }
    }
    return numbersThatMakeTarget;
  }
}
