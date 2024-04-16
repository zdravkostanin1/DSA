/// PAIRS IN ARRAY THAT SUM TO A PARTICULAR TARGET VALUE

// This runs ons on O(N) time complexity and O(N) space complexity.
List<int> twoNumberSum(List<int> nums, int target) {
  Map<int, bool> dic = {};
  
  for (int i = 0; i != nums.length; i++) {
    if (dic.containsKey(target - nums[i])){
      return [nums[i], target - nums[i]];
    } else {
      dic[nums[i]] = true;
    }
  }
  return [];
}
