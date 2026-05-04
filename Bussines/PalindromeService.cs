using Bussines.Interfaces;
using Domain.Helpers;

namespace Bussines.Services;

public class PalindromeService : IPalindromeService
{
    public bool IsPalindrome(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return false;

        string normalizedText = TextNormalizer.NormalizeText(text);

        int left = 0;
        int right = normalizedText.Length - 1;

        while (left < right)
        {
            if (normalizedText[left] != normalizedText[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}