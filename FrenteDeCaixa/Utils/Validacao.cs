namespace FrenteDeCaixa.Utils
{
    internal static class Validacao
    {
        public static bool IsNumeric(this string value)
        {
            return value.All(c => char.IsDigit(c) || c == ' ');
        }

        public static bool IsLetters(this string value)
        {
            return value.All(c => char.IsLetter(c) || c == ' ');
        }

        public static bool IsLetterAndNumeric(this string value)
        {
            return value.All(c => char.IsLetterOrDigit(c) || c == ' ');
        }
    }
}
