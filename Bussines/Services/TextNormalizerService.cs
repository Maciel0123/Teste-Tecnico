using Bussines.Interfaces;
using System.Text;

namespace Bussines.Services;

public class TextNormalizerService : ITextNormalizerService
{
    public string NormalizeShoutedText(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char current = text[i];

            if (current == '!' || current == '?')
            {
                bool hasQuestion = false;
                bool hasExclamation = false;

                while (i < text.Length && (text[i] == '!' || text[i] == '?'))
                {
                    if (text[i] == '?')
                        hasQuestion = true;

                    if (text[i] == '!')
                        hasExclamation = true;

                    i++;
                }

                if (hasQuestion)
                    result.Append('?');

                if (hasExclamation)
                    result.Append('!');

                i--;
            }
            else
            {
                result.Append(current);
            }
        }

        return result.ToString();
    }
}