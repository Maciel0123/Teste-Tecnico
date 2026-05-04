using System.Globalization;
using System.Text;

namespace Domain.Helpers;

public static class TextNormalizer
{
    public static string NormalizeText(string text)
    {
        text = text.ToLower();

        string normalized = text.Normalize(NormalizationForm.FormD);
        StringBuilder result = new StringBuilder();

        foreach (char character in normalized)
        {
            UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(character);

            if (category != UnicodeCategory.NonSpacingMark &&
                char.IsLetterOrDigit(character))
            {
                result.Append(character);
            }
        }

        return result.ToString();
    }
}