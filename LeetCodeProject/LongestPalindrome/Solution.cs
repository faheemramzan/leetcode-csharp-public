namespace TestProject.LongestPalindrome;

/// <summary>
/// https://leetcode.com/problems/longest-palindrome/
/// </summary>
public class Solution
{
    public string LongestPalindrome(string s) {
        string longestPalindrome = String.Empty;
        for(int i=0; i<s.Length; i++) {
            string partLongestPalindrome = String.Empty;
            for(int j=s.Length-1; j>i; j--) {
                string part = s.Substring(i, j-i+1);
                string partRev = String.Empty;
                
                bool isPalindrome = true;
                for(int k=0, l=part.Length-1; k<=l; k++,l--) {
                    if(part[k] != part[l]) {
                        isPalindrome = false;
                        break;                        
                    }
                }

                if(isPalindrome) {
                    partLongestPalindrome = part;
                    break;
                }
            }

            if(longestPalindrome == String.Empty || longestPalindrome.Length < partLongestPalindrome.Length) {
                longestPalindrome = partLongestPalindrome;
            }
        }

        if(longestPalindrome == String.Empty && s.Length > 0) {
            return s[0].ToString();
        }

        return longestPalindrome;
    }
}