class Solution {
  int numIdenticalPairs(List<int> nums) {
    int countOfGoodPairs = 0;
    if (1 <= nums.length && nums.length <= 100) {
      for (int i = 0; i <= nums.length; i++) {
        if (i != nums.length) {
          if (1 <= nums[i] && nums[i] <= 100) {
            for (int j = 0; j <= nums.length; j++) {
              if (j != nums.length) {
                if (nums[i] == nums[j] && i < j) {
                  countOfGoodPairs++;
                }
              }
            }
          }
        }
      }
    }
    return countOfGoodPairs;
  }
}
