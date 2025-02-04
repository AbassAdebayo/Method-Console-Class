namespace Method_Class;

public class Palindrome
{
    public bool IsPalindrome(string words)
    {
        string onlyWords = System.Text.RegularExpressions.Regex.Replace(words, @"[^a-zA-Z0-9]", "").ToLower();
        
        int length = onlyWords.Length;
        char[] reversedWords = new char[length];
        
        int j = 0;
        
        for(int i = length - 1; i >= 0; i--)
        {
            reversedWords[j] = onlyWords[i];
            j++;
        }
        
        //string reversedWords = new string(reversed);
        
        bool isPalindrome = true;
    
        for (int i = 0; i < length; i++)
        {
            if (reversedWords[i] != onlyWords[i])
            {
                isPalindrome = false;
                break;
            }
        }
        return isPalindrome;
    }
}