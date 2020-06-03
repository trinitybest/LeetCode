//Approach 1: Brute Force
class Solution {
    public int lengthOfLongestSubstring(String s) {
        int n = s.length();
        int ans = 0;
        for (int i = 0 ; i < n; i++){
            for(int j = i + 1; j <= n; j++){
                if (allUnique(s, i, j)) ans = Math.max(ans, j-i);
            }
        }
        return ans;
    }
    
    public boolean allUnique(String s, int start, int end){
        Set<Character> set = new HashSet<>();
        for (int i = start; i < end; i++){
            Character ch = s.charAt(i);
            if (set.contains(ch)) return false;
            set.add(ch);
        }
        return true;
    }
}

//Time Limit Exceeded


//Approach 2: Sliding Window
public class Solution {
    public int lengthOfLongestSubstring(String s) {
        int n = s.length();
        int ans = 0, j = 0, i = 0;
        Set<Character> set = new HashSet<>();
        while(i < n && j < n){
            if(!set.contains(s.charAt(j))){
                set.add(s.charAt(j++));
                ans = Math.max(ans, j-i);
            } else {
                set.remove(s.charAt(i++));
            }
        }
        return ans;
    }

}
