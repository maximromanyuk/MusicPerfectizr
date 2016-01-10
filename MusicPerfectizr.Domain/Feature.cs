using System;
using System.Text.RegularExpressions;

namespace MusicPerfectizr.Domain
{
    public static class Feature
    {
        // Повертає строку без недопустимих символів
        public static string CleanString(string strIn)
        {
            // якщо стрічка пуста - повертаємо її назад
            if (string.IsNullOrEmpty(strIn))
                return strIn;
            try
            {
                // заміняємо недопустимі символи пробілами
                return Regex.Replace(strIn, @"[^\w\.\&(),^%$#~{}`\[\]\'@-]", " ", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                // Danger!
                return string.Empty;
            }
        }
    }
}
