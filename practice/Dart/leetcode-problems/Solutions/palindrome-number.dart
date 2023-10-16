class Solution {
  bool isPalindrome(int x) {
    String s = "$x";
    if (s == s.split('').reversed.join()) {
      return true;
    } else {
      return false;
    }
  }
}
