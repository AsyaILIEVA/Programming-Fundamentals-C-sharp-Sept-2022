using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            const int passwordMinLength = 6;
            const int passwordMaxLength = 10;
            const int passwordDigitsMinCount = 2;

            bool IsPasswordValid = ValidatePassword(password, passwordMinLength, passwordMaxLength, passwordDigitsMinCount);
            
            if (IsPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ValidatePassword(string password, int passwordMinLength, int passwordMaxLength, int passwordDigitsMinCount)
        {
            bool IsPasswordValid = true;
            if (!ValidatePasswordLength(password, passwordMinLength, passwordMaxLength))
            {
                Console.WriteLine($"Password must be between {passwordMinLength} and {passwordMaxLength} characters");
                IsPasswordValid = false;
            }
            if (!ValidatePasswordIsAlphaNumerical(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                IsPasswordValid = false;
            }
            if (!ValidatePasswordsDigitsMinCount(password, passwordDigitsMinCount))
            {
                Console.WriteLine($"Password must have at least {passwordDigitsMinCount} digits");
                IsPasswordValid = false;
            }
            return IsPasswordValid;
        }
        static bool ValidatePasswordLength(string password, int minLength, int maxLength)
        {
            if (password.Length >= minLength && password.Length <= maxLength)
            {
                return true;
            }
            return false;
        }

        static bool ValidatePasswordIsAlphaNumerical(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool ValidatePasswordsDigitsMinCount(string password, int minDigitsCount)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= minDigitsCount;
        }
    }
}
